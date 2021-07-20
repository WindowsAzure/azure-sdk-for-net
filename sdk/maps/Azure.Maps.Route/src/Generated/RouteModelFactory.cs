// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Route.Models;

namespace Azure.Maps.Route
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class RouteModelFactory
    {
        /// <summary> Initializes a new instance of RouteMatrixResponse. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="matrix"> Results as a 2 dimensional array of route summaries. </param>
        /// <param name="summary"> Summary object. </param>
        /// <returns> A new <see cref="Models.RouteMatrixResponse"/> instance for mocking. </returns>
        public static RouteMatrixResponse RouteMatrixResponse(string formatVersion = null, IEnumerable<IList<RouteMatrixResult>> matrix = null, RouteMatrixSummary summary = null)
        {
            matrix ??= new List<IList<RouteMatrixResult>>();

            return new RouteMatrixResponse(formatVersion, matrix?.ToList(), summary);
        }

        /// <summary> Initializes a new instance of RouteMatrixResult. </summary>
        /// <param name="statusCode"> StatusCode property for the current cell in the input matrix. </param>
        /// <param name="response"> Response object of the current cell in the input matrix. </param>
        /// <returns> A new <see cref="Models.RouteMatrixResult"/> instance for mocking. </returns>
        public static RouteMatrixResult RouteMatrixResult(int? statusCode = null, RouteMatrixResultResponse response = null)
        {
            return new RouteMatrixResult(statusCode, response);
        }

        /// <summary> Initializes a new instance of RouteMatrixResultResponse. </summary>
        /// <param name="routeSummary"> Summary object for route section. </param>
        /// <returns> A new <see cref="Models.RouteMatrixResultResponse"/> instance for mocking. </returns>
        public static RouteMatrixResultResponse RouteMatrixResultResponse(RouteResultLegSummary routeSummary = null)
        {
            return new RouteMatrixResultResponse(routeSummary);
        }

        /// <summary> Initializes a new instance of RouteResultLegSummary. </summary>
        /// <param name="lengthInMeters"> Length In Meters property. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time in seconds property that includes the delay due to real-time traffic. Note that even when traffic=false travelTimeInSeconds still includes the delay due to traffic. If DepartAt is in the future, travel time is calculated using time-dependent historic traffic data. </param>
        /// <param name="trafficDelayInSeconds"> Estimated delay in seconds caused by the real-time incident(s) according to traffic information. For routes planned with departure time in the future, delays is always 0. To return additional travel times using different types of traffic information, parameter computeTravelTimeFor=all needs to be added. </param>
        /// <param name="departureTime"> Departure Time property. </param>
        /// <param name="arrivalTime"> Arrival Time property. </param>
        /// <param name="noTrafficTravelTimeInSeconds"> Estimated travel time calculated as if there are no delays on the route due to traffic conditions (e.g. congestion). Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="historicTrafficTravelTimeInSeconds"> Estimated travel time calculated using time-dependent historic traffic data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="liveTrafficIncidentsTravelTimeInSeconds"> Estimated travel time calculated using real-time speed data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="fuelConsumptionInLiters"> Estimated fuel consumption in liters using the Combustion Consumption Model. Included if vehicleEngineType is set to _combustion_ and constantSpeedConsumptionInLitersPerHundredkm is specified. The value will be non-negative. </param>
        /// <param name="batteryConsumptionInkWh"> Estimated electric energy consumption in kilowatt hours (kWh) using the Electric Consumption Model. Included if vehicleEngineType is set to electric and constantSpeedConsumptionInkWhPerHundredkm is specified. The value of batteryConsumptionInkWh includes the recuperated electric energy and can therefore be negative (which indicates gaining energy). If both maxChargeInkWh and currentChargeInkWh are specified, recuperation will be capped to ensure that the battery charge level never exceeds maxChargeInkWh. If neither maxChargeInkWh nor currentChargeInkWh are specified, unconstrained recuperation is assumed in the consumption calculation. </param>
        /// <returns> A new <see cref="Models.RouteResultLegSummary"/> instance for mocking. </returns>
        public static RouteResultLegSummary RouteResultLegSummary(int? lengthInMeters = null, int? travelTimeInSeconds = null, int? trafficDelayInSeconds = null, string departureTime = null, string arrivalTime = null, int? noTrafficTravelTimeInSeconds = null, int? historicTrafficTravelTimeInSeconds = null, int? liveTrafficIncidentsTravelTimeInSeconds = null, float? fuelConsumptionInLiters = null, float? batteryConsumptionInkWh = null)
        {
            return new RouteResultLegSummary(lengthInMeters, travelTimeInSeconds, trafficDelayInSeconds, departureTime, arrivalTime, noTrafficTravelTimeInSeconds, historicTrafficTravelTimeInSeconds, liveTrafficIncidentsTravelTimeInSeconds, fuelConsumptionInLiters, batteryConsumptionInkWh);
        }

        /// <summary> Initializes a new instance of RouteMatrixSummary. </summary>
        /// <param name="successfulRoutes"> Number of successful routes in the response. </param>
        /// <param name="totalRoutes"> Total number of routes requested. Number of cells in the input matrix. </param>
        /// <returns> A new <see cref="Models.RouteMatrixSummary"/> instance for mocking. </returns>
        public static RouteMatrixSummary RouteMatrixSummary(int? successfulRoutes = null, int? totalRoutes = null)
        {
            return new RouteMatrixSummary(successfulRoutes, totalRoutes);
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.ErrorResponse"/> instance for mocking. </returns>
        public static ErrorResponse ErrorResponse(ErrorDetail error = null)
        {
            return new ErrorResponse(error);
        }

        /// <summary> Initializes a new instance of ErrorDetail. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The error additional info. </param>
        /// <returns> A new <see cref="Models.ErrorDetail"/> instance for mocking. </returns>
        public static ErrorDetail ErrorDetail(string code = null, string message = null, string target = null, IEnumerable<ErrorDetail> details = null, IEnumerable<ErrorAdditionalInfo> additionalInfo = null)
        {
            details ??= new List<ErrorDetail>();
            additionalInfo ??= new List<ErrorAdditionalInfo>();

            return new ErrorDetail(code, message, target, details?.ToList(), additionalInfo?.ToList());
        }

        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        /// <returns> A new <see cref="Models.ErrorAdditionalInfo"/> instance for mocking. </returns>
        public static ErrorAdditionalInfo ErrorAdditionalInfo(string type = null, object info = null)
        {
            return new ErrorAdditionalInfo(type, info);
        }

        /// <summary> Initializes a new instance of RouteDirectionsResponse. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="routes"> Routes array. </param>
        /// <param name="optimizedWaypoints">
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response:
        /// 
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex=&quot;0&quot; optimizedIndex=&quot;1&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;1&quot; optimizedIndex=&quot;2&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;2&quot; optimizedIndex=&quot;0&quot;/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        /// 
        /// means that the original sequence is [0, 1, 2] and optimized sequence is [1, 2, 0]. Since the index starts by 0 the original is &quot;first, second, third&quot; while the optimized is &quot;second, third, first&quot;.
        /// </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsResponse"/> instance for mocking. </returns>
        public static RouteDirectionsResponse RouteDirectionsResponse(string formatVersion = null, IEnumerable<RouteDirectionsResult> routes = null, IEnumerable<RouteOptimizedWaypoint> optimizedWaypoints = null, RouteResponseReport report = null)
        {
            routes ??= new List<RouteDirectionsResult>();
            optimizedWaypoints ??= new List<RouteOptimizedWaypoint>();

            return new RouteDirectionsResponse(formatVersion, routes?.ToList(), optimizedWaypoints?.ToList(), report);
        }

        /// <summary> Initializes a new instance of RouteDirectionsResult. </summary>
        /// <param name="summary"> Summary object. </param>
        /// <param name="legs"> Legs array. </param>
        /// <param name="sections"> Sections array. </param>
        /// <param name="guidance"> Contains guidance related elements. This field is present only when guidance was requested and is available. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsResult"/> instance for mocking. </returns>
        public static RouteDirectionsResult RouteDirectionsResult(RouteDirectionsSummary summary = null, IEnumerable<RouteResultLeg> legs = null, IEnumerable<RouteResultSection> sections = null, RouteResultGuidance guidance = null)
        {
            legs ??= new List<RouteResultLeg>();
            sections ??= new List<RouteResultSection>();

            return new RouteDirectionsResult(summary, legs?.ToList(), sections?.ToList(), guidance);
        }

        /// <summary> Initializes a new instance of RouteDirectionsSummary. </summary>
        /// <param name="lengthInMeters"> Length In Meters property. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time in seconds property that includes the delay due to real-time traffic. Note that even when traffic=false travelTimeInSeconds still includes the delay due to traffic. If DepartAt is in the future, travel time is calculated using time-dependent historic traffic data. </param>
        /// <param name="trafficDelayInSeconds"> Estimated delay in seconds caused by the real-time incident(s) according to traffic information. For routes planned with departure time in the future, delays is always 0. To return additional travel times using different types of traffic information, parameter computeTravelTimeFor=all needs to be added. </param>
        /// <param name="departureTime"> Departure Time property. </param>
        /// <param name="arrivalTime"> Arrival Time property. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsSummary"/> instance for mocking. </returns>
        public static RouteDirectionsSummary RouteDirectionsSummary(int? lengthInMeters = null, int? travelTimeInSeconds = null, int? trafficDelayInSeconds = null, string departureTime = null, string arrivalTime = null)
        {
            return new RouteDirectionsSummary(lengthInMeters, travelTimeInSeconds, trafficDelayInSeconds, departureTime, arrivalTime);
        }

        /// <summary> Initializes a new instance of RouteResultLeg. </summary>
        /// <param name="summary"> Summary object for route section. </param>
        /// <param name="points"> Points array. </param>
        /// <returns> A new <see cref="Models.RouteResultLeg"/> instance for mocking. </returns>
        public static RouteResultLeg RouteResultLeg(RouteResultLegSummary summary = null, IEnumerable<CoordinatesPair> points = null)
        {
            points ??= new List<CoordinatesPair>();

            return new RouteResultLeg(summary, points?.ToList());
        }

        /// <summary> Initializes a new instance of CoordinatesPair. </summary>
        /// <param name="latitude"> Latitude property. </param>
        /// <param name="longitude"> Longitude property. </param>
        /// <returns> A new <see cref="Models.CoordinatesPair"/> instance for mocking. </returns>
        public static CoordinatesPair CoordinatesPair(double? latitude = null, double? longitude = null)
        {
            return new CoordinatesPair(latitude, longitude);
        }

        /// <summary> Initializes a new instance of RouteResultSection. </summary>
        /// <param name="startPointIndex"> Start Point Index property. </param>
        /// <param name="endPointIndex"> End Point Index property. </param>
        /// <param name="sectionType"> Section Type property. </param>
        /// <param name="travelMode"> Travel Mode property. </param>
        /// <param name="simpleCategory"> Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See &quot;tec&quot; for detailed information. </param>
        /// <param name="effectiveSpeedInKmh"> Effective speed of the incident in km/h, averaged over its entire length. </param>
        /// <param name="delayInSeconds"> Delay in seconds caused by the incident. </param>
        /// <param name="magnitudeOfDelay"> The magnitude of delay caused by the incident. These values correspond to the values of the response field ty of the [Get Traffic Incident Detail API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail). </param>
        /// <param name="tec"> Details of the traffic event, using definitions in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can contain effectCode and causes elements. </param>
        /// <returns> A new <see cref="Models.RouteResultSection"/> instance for mocking. </returns>
        public static RouteResultSection RouteResultSection(int? startPointIndex = null, int? endPointIndex = null, string sectionType = null, string travelMode = null, string simpleCategory = null, int? effectiveSpeedInKmh = null, int? delayInSeconds = null, MagnitudeOfDelay? magnitudeOfDelay = null, RouteResultSectionTec tec = null)
        {
            return new RouteResultSection(startPointIndex, endPointIndex, sectionType, travelMode, simpleCategory, effectiveSpeedInKmh, delayInSeconds, magnitudeOfDelay, tec);
        }

        /// <summary> Initializes a new instance of RouteResultSectionTec. </summary>
        /// <param name="effectCode"> The effect on the traffic flow. Contains a value in the tec001:EffectCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can be used to color-code traffic events according to severity. </param>
        /// <param name="causes"> Causes array. </param>
        /// <returns> A new <see cref="Models.RouteResultSectionTec"/> instance for mocking. </returns>
        public static RouteResultSectionTec RouteResultSectionTec(int? effectCode = null, IEnumerable<RouteResultSectionTecCause> causes = null)
        {
            causes ??= new List<RouteResultSectionTecCause>();

            return new RouteResultSectionTec(effectCode, causes?.ToList());
        }

        /// <summary> Initializes a new instance of RouteResultSectionTecCause. </summary>
        /// <param name="mainCauseCode"> The main cause of the traffic event. Contains a value in the tec002:CauseCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        /// <param name="subCauseCode"> The subcause of the traffic event. Contains a value in the sub cause table defined by the mainCauseCode, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        /// <returns> A new <see cref="Models.RouteResultSectionTecCause"/> instance for mocking. </returns>
        public static RouteResultSectionTecCause RouteResultSectionTecCause(int? mainCauseCode = null, int? subCauseCode = null)
        {
            return new RouteResultSectionTecCause(mainCauseCode, subCauseCode);
        }

        /// <summary> Initializes a new instance of RouteResultGuidance. </summary>
        /// <param name="instructions"> A list of instructions describing maneuvers. </param>
        /// <param name="instructionGroups"> Groups a sequence of instruction elements which are related to each other. </param>
        /// <returns> A new <see cref="Models.RouteResultGuidance"/> instance for mocking. </returns>
        public static RouteResultGuidance RouteResultGuidance(IEnumerable<RouteResultInstruction> instructions = null, IEnumerable<RouteResultInstructionGroup> instructionGroups = null)
        {
            instructions ??= new List<RouteResultInstruction>();
            instructionGroups ??= new List<RouteResultInstructionGroup>();

            return new RouteResultGuidance(instructions?.ToList(), instructionGroups?.ToList());
        }

        /// <summary> Initializes a new instance of RouteResultInstruction. </summary>
        /// <param name="routeOffsetInMeters"> Distance from the start of the route to the point of the instruction. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time up to the point corresponding to routeOffsetInMeters. </param>
        /// <param name="point"> A location represented as a latitude and longitude. </param>
        /// <param name="pointIndex"> The index of the point in the list of polyline &quot;points&quot; corresponding to the point of the instruction. </param>
        /// <param name="instructionType"> Type of the instruction, e.g., turn or change of road form. </param>
        /// <param name="roadNumbers"> The road number(s) of the next significant road segment(s) after the maneuver, or of the road(s) to be followed. Example: [&quot;E34&quot;, &quot;N205&quot;]. </param>
        /// <param name="exitNumber"> The number(s) of a highway exit taken by the current maneuver. If an exit has multiple exit numbers, they will be separated by &quot;,&quot; and possibly aggregated by &quot;-&quot;, e.g., &quot;10, 13-15&quot;. </param>
        /// <param name="street"> Street name of the next significant road segment after the maneuver, or of the street that should be followed. </param>
        /// <param name="signpostText"> The text on a signpost which is most relevant to the maneuver, or to the direction that should be followed. </param>
        /// <param name="countryCode"> 3-character [ISO 3166-1](https://www.iso.org/iso-3166-country-codes.html) alpha-3 country code. E.g. USA. </param>
        /// <param name="stateCode"> A subdivision (e.g., state) of the country, represented by the second part of an [ISO 3166-2](https://www.iso.org/standard/63546.html) code. This is only available for some countries like the US, Canada, and Mexico. </param>
        /// <param name="junctionType"> The type of the junction where the maneuver takes place. For larger roundabouts, two separate instructions are generated for entering and leaving the roundabout. </param>
        /// <param name="turnAngleInDecimalDegrees">
        /// Indicates the direction of an instruction. If junctionType indicates a turn instruction:
        /// 
        ///   * 180 = U-turn
        ///   * [-179, -1] = Left turn
        ///   * 0 = Straight on (a &apos;0 degree&apos; turn)
        ///   * [1, 179] = Right turn
        /// 
        /// If junctionType indicates a bifurcation instruction:
        /// 
        ///   * &lt;0 - keep left
        ///   * \&gt;0 - keep right.
        /// </param>
        /// <param name="roundaboutExitNumber"> This indicates which exit to take at a roundabout. </param>
        /// <param name="possibleCombineWithNext"> It is possible to optionally combine the instruction with the next one. This can be used to build messages like &quot;Turn left and then turn right&quot;. </param>
        /// <param name="drivingSide"> Indicates left-hand vs. right-hand side driving at the point of the maneuver. </param>
        /// <param name="maneuver"> A code identifying the maneuver. </param>
        /// <param name="message"> A human-readable message for the maneuver. </param>
        /// <param name="combinedMessage">
        /// A human-readable message for the maneuver combined with the message from the next instruction. Sometimes it is possible to combine two successive instructions into a single instruction making it easier to follow. When this is the case the possibleCombineWithNext flag will be true. For example:
        /// 
        /// ```
        /// 10. Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// 11. Follow Einsteinweg/A10/E22 towards Ring Amsterdam
        /// ```
        /// 
        /// The possibleCombineWithNext flag on instruction 10 is true. This indicates to the clients of coded guidance that it can be combined with instruction 11. The instructions will be combined automatically for clients requesting human-readable guidance. The combinedMessage field contains the combined message:
        /// 
        /// ```
        /// Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// then follow Einsteinweg/A10/E22 towards Ring Amsterdam.
        /// ```.
        /// </param>
        /// <returns> A new <see cref="Models.RouteResultInstruction"/> instance for mocking. </returns>
        public static RouteResultInstruction RouteResultInstruction(int? routeOffsetInMeters = null, int? travelTimeInSeconds = null, CoordinatesPair point = null, int? pointIndex = null, GuidanceInstructionType? instructionType = null, IEnumerable<string> roadNumbers = null, string exitNumber = null, string street = null, string signpostText = null, string countryCode = null, string stateCode = null, JunctionType? junctionType = null, int? turnAngleInDecimalDegrees = null, string roundaboutExitNumber = null, bool? possibleCombineWithNext = null, DrivingSide? drivingSide = null, GuidanceManeuver? maneuver = null, string message = null, string combinedMessage = null)
        {
            roadNumbers ??= new List<string>();

            return new RouteResultInstruction(routeOffsetInMeters, travelTimeInSeconds, point, pointIndex, instructionType, roadNumbers?.ToList(), exitNumber, street, signpostText, countryCode, stateCode, junctionType, turnAngleInDecimalDegrees, roundaboutExitNumber, possibleCombineWithNext, drivingSide, maneuver, message, combinedMessage);
        }

        /// <summary> Initializes a new instance of RouteResultInstructionGroup. </summary>
        /// <param name="firstInstructionIndex"> Index of the first instruction. </param>
        /// <param name="lastInstructionIndex"> Index of the last instruction. </param>
        /// <param name="groupLengthInMeters"> Length of the group. </param>
        /// <param name="groupMessage"> Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged). </param>
        /// <returns> A new <see cref="Models.RouteResultInstructionGroup"/> instance for mocking. </returns>
        public static RouteResultInstructionGroup RouteResultInstructionGroup(int? firstInstructionIndex = null, int? lastInstructionIndex = null, int? groupLengthInMeters = null, string groupMessage = null)
        {
            return new RouteResultInstructionGroup(firstInstructionIndex, lastInstructionIndex, groupLengthInMeters, groupMessage);
        }

        /// <summary> Initializes a new instance of RouteOptimizedWaypoint. </summary>
        /// <param name="providedIndex"> Way point index provided by the user. </param>
        /// <param name="optimizedIndex"> Optimized way point index from the system. </param>
        /// <returns> A new <see cref="Models.RouteOptimizedWaypoint"/> instance for mocking. </returns>
        public static RouteOptimizedWaypoint RouteOptimizedWaypoint(int? providedIndex = null, int? optimizedIndex = null)
        {
            return new RouteOptimizedWaypoint(providedIndex, optimizedIndex);
        }

        /// <summary> Initializes a new instance of RouteResponseReport. </summary>
        /// <param name="effectiveSettings"> Effective parameters or data used when calling this Route API. </param>
        /// <returns> A new <see cref="Models.RouteResponseReport"/> instance for mocking. </returns>
        public static RouteResponseReport RouteResponseReport(IEnumerable<RouteResponseReportEffectiveSetting> effectiveSettings = null)
        {
            effectiveSettings ??= new List<RouteResponseReportEffectiveSetting>();

            return new RouteResponseReport(effectiveSettings?.ToList());
        }

        /// <summary> Initializes a new instance of RouteResponseReportEffectiveSetting. </summary>
        /// <param name="key"> Name of the parameter used. </param>
        /// <param name="value"> Value of the parameter used. </param>
        /// <returns> A new <see cref="Models.RouteResponseReportEffectiveSetting"/> instance for mocking. </returns>
        public static RouteResponseReportEffectiveSetting RouteResponseReportEffectiveSetting(string key = null, string value = null)
        {
            return new RouteResponseReportEffectiveSetting(key, value);
        }

        /// <summary> Initializes a new instance of GetRouteRangeResponse. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="reachableRange"> Reachable Range. </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        /// <returns> A new <see cref="Models.GetRouteRangeResponse"/> instance for mocking. </returns>
        public static GetRouteRangeResponse GetRouteRangeResponse(string formatVersion = null, RouteRange reachableRange = null, RouteResponseReport report = null)
        {
            return new GetRouteRangeResponse(formatVersion, reachableRange, report);
        }

        /// <summary> Initializes a new instance of RouteRange. </summary>
        /// <param name="center"> Center point of the reachable range. </param>
        /// <param name="boundary"> Polygon boundary of the reachable range represented as a list of points. </param>
        /// <returns> A new <see cref="Models.RouteRange"/> instance for mocking. </returns>
        public static RouteRange RouteRange(CoordinatesPair center = null, IEnumerable<CoordinatesPair> boundary = null)
        {
            boundary ??= new List<CoordinatesPair>();

            return new RouteRange(center, boundary?.ToList());
        }

        /// <summary> Initializes a new instance of BatchResponse. </summary>
        /// <param name="summary"> Summary for the batch request. </param>
        /// <returns> A new <see cref="Models.BatchResponse"/> instance for mocking. </returns>
        public static BatchResponse BatchResponse(BatchResponseSummary summary = null)
        {
            return new BatchResponse(summary);
        }

        /// <summary> Initializes a new instance of BatchResponseSummary. </summary>
        /// <param name="successfulRequests"> Number of successful requests in the batch. </param>
        /// <param name="totalRequests"> Total number of requests in the batch. </param>
        /// <returns> A new <see cref="Models.BatchResponseSummary"/> instance for mocking. </returns>
        public static BatchResponseSummary BatchResponseSummary(int? successfulRequests = null, int? totalRequests = null)
        {
            return new BatchResponseSummary(successfulRequests, totalRequests);
        }

        /// <summary> Initializes a new instance of RouteDirectionsBatchResponse. </summary>
        /// <param name="summary"> Summary for the batch request. </param>
        /// <param name="batchItems"> Array containing the batch results. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsBatchResponse"/> instance for mocking. </returns>
        public static RouteDirectionsBatchResponse RouteDirectionsBatchResponse(BatchResponseSummary summary = null, IEnumerable<RouteDirectionsBatchItem> batchItems = null)
        {
            batchItems ??= new List<RouteDirectionsBatchItem>();

            return new RouteDirectionsBatchResponse(summary, batchItems?.ToList());
        }

        /// <summary> Initializes a new instance of BatchItem. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <returns> A new <see cref="Models.BatchItem"/> instance for mocking. </returns>
        public static BatchItem BatchItem(float? statusCode = null)
        {
            return new BatchItem(statusCode);
        }

        /// <summary> Initializes a new instance of RouteDirectionsBatchItem. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <param name="response"> The result of the query. RouteDirectionsResponse if the query completed successfully, ErrorResponse otherwise. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsBatchItem"/> instance for mocking. </returns>
        public static RouteDirectionsBatchItem RouteDirectionsBatchItem(float? statusCode = null, RouteDirectionsBatchItemResponse response = null)
        {
            return new RouteDirectionsBatchItem(statusCode, response);
        }

        /// <summary> Initializes a new instance of RouteDirectionsBatchItemResponse. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="routes"> Routes array. </param>
        /// <param name="optimizedWaypoints">
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response:
        /// 
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex=&quot;0&quot; optimizedIndex=&quot;1&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;1&quot; optimizedIndex=&quot;2&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;2&quot; optimizedIndex=&quot;0&quot;/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        /// 
        /// means that the original sequence is [0, 1, 2] and optimized sequence is [1, 2, 0]. Since the index starts by 0 the original is &quot;first, second, third&quot; while the optimized is &quot;second, third, first&quot;.
        /// </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.RouteDirectionsBatchItemResponse"/> instance for mocking. </returns>
        public static RouteDirectionsBatchItemResponse RouteDirectionsBatchItemResponse(string formatVersion = null, IEnumerable<RouteDirectionsResult> routes = null, IEnumerable<RouteOptimizedWaypoint> optimizedWaypoints = null, RouteResponseReport report = null, ErrorDetail error = null)
        {
            routes ??= new List<RouteDirectionsResult>();
            optimizedWaypoints ??= new List<RouteOptimizedWaypoint>();

            return new RouteDirectionsBatchItemResponse(formatVersion, routes?.ToList(), optimizedWaypoints?.ToList(), report, error);
        }
    }
}
