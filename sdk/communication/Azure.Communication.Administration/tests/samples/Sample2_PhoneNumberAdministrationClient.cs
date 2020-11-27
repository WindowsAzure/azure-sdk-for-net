﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Administration.Models;
using Azure.Communication.Administration.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.Administration.Samples
{
    /// <summary>
    /// Basic Azure Communication Administration samples.
    /// </summary>
    public class Sample2_PhoneNumberAdministrationClient : PhoneNumberAdministrationClientLiveTestBase
    {
        public Sample2_PhoneNumberAdministrationClient(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [AsyncOnly]
        public async Task PurchaseAndReleaseAsync()
        {
            if (!IncludePhoneNumberLiveTests)
                Assert.Ignore("Include phone number live tests flag is off.");

            const string locale = "en-US";
            var connectionString = TestEnvironment.ConnectionString;
            var client = CreateClient(false);

            const string countryCode = "US";

            #region Snippet:GetPhonePlanGroupsAsync
            var phonePlanGroups = client.GetPhonePlanGroupsAsync(countryCode, locale);

            await foreach (var phonePlanGroup in phonePlanGroups)
            {
                Console.WriteLine($"Plan group: {phonePlanGroup.LocalizedName}, type: {phonePlanGroup.PhoneNumberType}");
            }
            #endregion Snippet:GetPhonePlanGroupsAsync

            var phonePlanGroupsList = await phonePlanGroups.ToEnumerableAsync();
            string phonePlanGroupId = phonePlanGroupsList.First(group => group.PhoneNumberType == PhoneNumberType.TollFree).PhonePlanGroupId;

            #region Snippet:GetPhonePlansAsync
            var phonePlans = client.GetPhonePlansAsync(countryCode, phonePlanGroupId, locale);
            await foreach (var phonePlan in phonePlans)
            {
                Console.WriteLine($"Plan: {phonePlan.LocalizedName}, {phonePlan.LocationType}");
            }
            #endregion Snippet:GetPhonePlansAsync

            var firstphonePlan = (await phonePlans.ToEnumerableAsync()).First();
            var areaCode = firstphonePlan.AreaCodes.First();
            var phonePlanId = firstphonePlan.PhonePlanId;

            #region Snippet:ReservePhoneNumbersAsync
            var reservationName = "My reservation";
            var reservationDescription = "reservation description";
            var reservationOptions = new CreateReservationOptions(reservationName, reservationDescription, new[] { phonePlanId }, areaCode);
            reservationOptions.Quantity = 1;

            var reservationOperation = await client.StartReservationAsync(reservationOptions);
            await reservationOperation.WaitForCompletionAsync();
            #endregion Snippet:ReservePhoneNumbersAsync

            #region Snippet:PersistReservePhoneNumbersOperationAsync
            var reservationId = reservationOperation.Id;

            // persist reservationOperationId and then continue with new operation

            var newPhoneNumberReservationOperation = new PhoneNumberReservationOperation(client, reservationId);
            await newPhoneNumberReservationOperation.WaitForCompletionAsync();
            #endregion Snippet:PersistReservePhoneNumbersOperationAsync

            #region Snippet:StartPurchaseReservationAsync
            var reservationPurchaseOperation = await client.StartPurchaseReservationAsync(reservationId);
            await reservationPurchaseOperation.WaitForCompletionAsync();
            #endregion Snippet:StartPurchaseReservationAsync

            #region Snippet:ListAcquiredPhoneNumbersAsync
            var acquiredPhoneNumbers = client.GetAllPhoneNumbersAsync(locale);

            await foreach (var phoneNumber in acquiredPhoneNumbers)
            {
                Console.WriteLine($"Phone number: {phoneNumber.PhoneNumber}, activation state: {phoneNumber.ActivationState}");
            }
            #endregion Snippet:ListAcquiredPhoneNumbersAsync

            var acquiredPhoneNumber = reservationOperation.Value.PhoneNumbers.First();

            #region Snippet:ReleasePhoneNumbersAsync
            //@@var acquiredPhoneNumber = "<acquired_phone_number>";
            var phoneNumbers = new List<PhoneNumber> { new PhoneNumber(acquiredPhoneNumber) };
            var phoneNumberReleaseOperation = client.StartReleasePhoneNumbers(phoneNumbers);
            await phoneNumberReleaseOperation.WaitForCompletionAsync();
            #endregion Snippet:ReleasePhoneNumbersAsync
        }


        [Test]
        [SyncOnly]
        public void PurchaseAndRelease()
        {
            if (!IncludePhoneNumberLiveTests)
                Assert.Ignore("Include phone number live tests flag is off.");

            const string locale = "en-US";
            var connectionString = TestEnvironment.ConnectionString;

            #region Snippet:CreatePhoneNumberAdministrationClient
            // Get a connection string to our Azure Communication resource.
            //@@var connectionString = "<connection_string>";
            var client = new PhoneNumberAdministrationClient(connectionString);
            #endregion Snippet:CreatePhoneNumberAdministrationClient

            client = CreateClient(false);

            const string countryCode = "US";

            #region Snippet:GetPhonePlanGroups
            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);

            foreach (var phonePlanGroup in phonePlanGroups)
            {
                Console.WriteLine($"Plan group: {phonePlanGroup.LocalizedName}, type: {phonePlanGroup.PhoneNumberType}");
            }
            #endregion Snippet:GetPhonePlanGroups

            var tollFreePhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.TollFree);
            var phonePlanGroupId = tollFreePhonePlanGroup.PhonePlanGroupId;

            #region Snippet:GetPhonePlans
            var phonePlans = client.GetPhonePlans(countryCode, phonePlanGroupId, locale);
            foreach (var phonePlan in phonePlans)
            {
                Console.WriteLine($"Plan: {phonePlan.LocalizedName}, {phonePlan.LocationType}");
            }
            #endregion Snippet:GetPhonePlans

            var tollFreePhonePlan = phonePlans.First();
            var phonePlanId = tollFreePhonePlan.PhonePlanId;
            var areaCode = tollFreePhonePlan.AreaCodes.First();

            #region Snippet:ReservePhoneNumbers
            var reservationName = "My reservation";
            var reservationDescription = "reservation description";
            var reservationOptions = new CreateReservationOptions(reservationName, reservationDescription, new[] { phonePlanId }, areaCode);
            reservationOptions.Quantity = 1;

            var reservationOperation = client.StartReservation(reservationOptions);

            while (true)
            {
                reservationOperation.UpdateStatus();
                if (reservationOperation.HasCompleted)
                {
                    break;
                }

                Thread.Sleep(1000);
            }

            #endregion Snippet:ReservePhoneNumbers

            #region Snippet:PersistReservePhoneNumbersOperation
            var reservationId = reservationOperation.Id;

            // persist reservationOperationId and then continue with new operation

            var newPhoneNumberReservationOperation = new PhoneNumberReservationOperation(client, reservationId);

            while (true)
            {
                newPhoneNumberReservationOperation.UpdateStatus();
                if (newPhoneNumberReservationOperation.HasCompleted)
                {
                    break;
                }

                Thread.Sleep(1000);
            }
            #endregion Snippet:PersistReservePhoneNumbersOperation

            #region Snippet:StartPurchaseReservation
            var reservationPurchaseOperation = client.StartPurchaseReservation(reservationId);

            while (true)
            {
                reservationPurchaseOperation.UpdateStatus();
                if (reservationPurchaseOperation.HasCompleted)
                {
                    break;
                }

                Thread.Sleep(1000);
            }
            #endregion Snippet:StartPurchaseReservation

            #region Snippet:ListAcquiredPhoneNumbers
            var acquiredPhoneNumbers = client.GetAllPhoneNumbers(locale);

            foreach (var phoneNumber in acquiredPhoneNumbers)
            {
                Console.WriteLine($"Phone number: {phoneNumber.PhoneNumber}, activation state: {phoneNumber.ActivationState}");
            }
            #endregion Snippet:ListAcquiredPhoneNumbers

            var acquiredPhoneNumber = reservationOperation.Value.PhoneNumbers.First();

            #region Snippet:ReleasePhoneNumbers
            //@@var acquiredPhoneNumber = "<acquired_phone_number>";
            var phoneNumbers = new List<PhoneNumber> { new PhoneNumber(acquiredPhoneNumber) };
            var phoneNumberReleaseOperation = client.StartReleasePhoneNumbers(phoneNumbers);

            while (true)
            {
                phoneNumberReleaseOperation.UpdateStatus();
                if (phoneNumberReleaseOperation.HasCompleted)
                {
                    break;
                }

                Thread.Sleep(1000);
            }
            #endregion Snippet:ReleasePhoneNumbers
        }

        [Test]
        [SyncOnly]
        public void GetAllSupportedCountries()
        {
            var client = CreateClient(false);
            const string locale = "en-US";

            #region Snippet:GetAllSupportedCountries
            var supportedCountries = client.GetAllSupportedCountries(locale);
            foreach (var country in supportedCountries)
            {
                Console.WriteLine($"Supported country code: {country.CountryCode}, name: {country.LocalizedName}");
            }
            #endregion Snippet:GetAllSupportedCountries
        }

        [Test]
        [AsyncOnly]
        public async Task GetAllSupportedCountriesAsync()
        {
            var client = CreateClient(false);
            const string locale = "en-US";

            #region Snippet:GetAllSupportedCountriesAsync
            var supportedCountries = client.GetAllSupportedCountriesAsync(locale);
            await foreach (var country in supportedCountries)
            {
                Console.WriteLine($"Supported country code: {country.CountryCode}, name: {country.LocalizedName}");
            }
            #endregion Snippet:GetAllSupportedCountriesAsync
        }

        [Test]
        [SyncOnly]
        public void GetPhonePlanLocationOptions()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var geographicPhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.Geographic);

            var phonePlans = client.GetPhonePlans(countryCode, geographicPhonePlanGroup.PhonePlanGroupId, locale);
            var phonePlanId = phonePlans.First().PhonePlanId;

            #region Snippet:GetPhonePlanLocationOptions

            var locationOptionsResponse = client.GetPhonePlanLocationOptions(countryCode, geographicPhonePlanGroup.PhonePlanGroupId, phonePlanId);

            void PrintLocationOption(LocationOptions locationOptions)
            {
                Console.WriteLine($"LabelId: {locationOptions.LabelId}, LabelName: {locationOptions.LabelName}");

                foreach (var locationOption in locationOptions.Options)
                {
                    Console.WriteLine($"Name: {locationOption.Name}, Value: {locationOption.Value}");

                    foreach (var subLocationOption in locationOption.LocationOptions)
                        PrintLocationOption(subLocationOption);
                }
            }
            PrintLocationOption(locationOptionsResponse.Value.LocationOptions);

            #endregion Snippet:GetPhonePlanLocationOptions
        }

        [Test]
        [AsyncOnly]
        public async Task GetPhonePlanLocationOptionsAsync()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var geographicPhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.Geographic);

            var phonePlans = client.GetPhonePlans(countryCode, geographicPhonePlanGroup.PhonePlanGroupId, locale);
            var phonePlanId = phonePlans.First().PhonePlanId;
            var geographicPhonePlanGroupId = geographicPhonePlanGroup.PhonePlanGroupId;

            #region Snippet:GetPhonePlanLocationOptionsAsync

            var locationOptionsResponse = await client.GetPhonePlanLocationOptionsAsync(countryCode, geographicPhonePlanGroupId, phonePlanId);

            void printLocationOption(LocationOptions locationOptions)
            {
                Console.WriteLine($"LabelId: {locationOptions.LabelId}, LabelName: {locationOptions.LabelName}");

                foreach (var locationOption in locationOptions.Options)
                {
                    Console.WriteLine($"Name: {locationOption.Name}, Value: {locationOption.Value}");

                    foreach (var subLocationOption in locationOption.LocationOptions)
                        printLocationOption(subLocationOption);
                }
            }
            printLocationOption(locationOptionsResponse.Value.LocationOptions);

            #endregion Snippet:GetPhonePlanLocationOptionsAsync
        }

        [Test]
        [SyncOnly]
        public void GeographicalAreaCodes()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var geographicPhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.Geographic);

            var phonePlans = client.GetPhonePlans(countryCode, geographicPhonePlanGroup.PhonePlanGroupId, locale);
            var geographicPhonePlan = phonePlans.First();
            var geographicPhonePlanGroupId = geographicPhonePlanGroup.PhonePlanGroupId;
            var geographicPhonePlanId = geographicPhonePlan.PhonePlanId;

            #region Snippet:GeographicalAreaCodes
            var locationOptionsResponse = client.GetPhonePlanLocationOptions(countryCode, geographicPhonePlanGroupId, geographicPhonePlanId);
            var state = locationOptionsResponse.Value.LocationOptions.Options.First();

            var locationOptionsQueries = new List<LocationOptionsQuery>
            {
                new LocationOptionsQuery
                {
                    LabelId = "state",
                    OptionsValue = state.Value
                },
                new LocationOptionsQuery
                {
                    LabelId = "city",
                    OptionsValue = state.LocationOptions.First().Options.First().Value
                }
            };

            var areaCodes = client.GetAllAreaCodes(geographicPhonePlan.LocationType.ToString(), countryCode, geographicPhonePlan.PhonePlanId, locationOptionsQueries);

            foreach (var areaCode in areaCodes.Value.PrimaryAreaCodes)
            {
                Console.WriteLine($"Primary area code: {areaCode}");
            }
            #endregion Snippet:GeographicalAreaCodes
        }

        [Test]
        [AsyncOnly]
        public async Task GeographicalAreaCodesAsync()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var geographicPhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.Geographic);

            var phonePlans = client.GetPhonePlans(countryCode, geographicPhonePlanGroup.PhonePlanGroupId, locale);
            var geographicPhonePlan = phonePlans.First();
            var geographicPhonePlanGroupId = geographicPhonePlanGroup.PhonePlanGroupId;
            var geographicPhonePlanId = geographicPhonePlan.PhonePlanId;

            #region Snippet:GeographicalAreaCodesAsync
            var locationOptionsResponse = await client.GetPhonePlanLocationOptionsAsync(countryCode, geographicPhonePlanGroupId, geographicPhonePlanId);
            var state = locationOptionsResponse.Value.LocationOptions.Options.First();

            var locationOptionsQueries = new List<LocationOptionsQuery>{
                new LocationOptionsQuery
                {
                    LabelId = "state",
                    OptionsValue = state.Value
                },
                new LocationOptionsQuery
                {
                    LabelId = "city",
                    OptionsValue = state.LocationOptions.First().Options.First().Value
                }
            };

            var areaCodes = await client.GetAllAreaCodesAsync(geographicPhonePlan.LocationType.ToString(), countryCode, geographicPhonePlan.PhonePlanId, locationOptionsQueries);

            foreach (var areaCode in areaCodes.Value.PrimaryAreaCodes)
            {
                Console.WriteLine($"Primary area code: {areaCode}");
            }
            #endregion Snippet:GeographicalAreaCodesAsync
        }

        [Test]
        [SyncOnly]
        public void TollFreePlanAreCodes()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var tollFreePhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.TollFree);
            var tollFreePhonePlanGroupId = tollFreePhonePlanGroup.PhonePlanGroupId;
            #region Snippet:TollFreePlanAreCodes

            var phonePlans = client.GetPhonePlans(countryCode, tollFreePhonePlanGroupId, locale);
            var tollFreePhonePlan = phonePlans.First();

            foreach (var areaCode in tollFreePhonePlan.AreaCodes)
            {
                Console.WriteLine($"Area code: {areaCode}");
            }

            #endregion Snippet:TollFreePlanAreCodes
        }

        [Test]
        [AsyncOnly]
        public async Task TollFreePlanAreCodesAsync()
        {
            var client = CreateClient(false);
            const string locale = "en-US";
            const string countryCode = "US";

            var phonePlanGroups = client.GetPhonePlanGroups(countryCode, locale);
            var tollFreePhonePlanGroup = phonePlanGroups.First(group => group.PhoneNumberType == PhoneNumberType.TollFree);

            #region Snippet:TollFreePlanAreCodesAsync

            var phonePlans = client.GetPhonePlansAsync(countryCode, tollFreePhonePlanGroup.PhonePlanGroupId, locale);
            var tollFreePhonePlan = (await phonePlans.ToEnumerableAsync()).First();

            foreach (var areaCode in tollFreePhonePlan.AreaCodes)
            {
                Console.WriteLine($"Area code: {areaCode}");
            }

            #endregion Snippet:TollFreePlanAreCodesAsync
        }
    }
}
