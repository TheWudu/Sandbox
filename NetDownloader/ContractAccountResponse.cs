using System;
using System.Collections.Generic;

namespace NetDowloader;

public record ContractAccountResponse
{
    public string ContractAccountNumber { get; init; } = default!;
    public string BusinessPartnerNumber { get; init; } = default!;
    public string Description { get; init; } = default!;
    public bool Active { get; init; }
    public string Branch { get; init; } = default!;
    public Address Address { get; init; } = default!;
    public bool BilledByProvider { get; init; }

    public Dictionary<string, object>? BankAccountIn { get; init; }
    public Dictionary<string, object>? BankAccountOut { get; init; }
    public Dictionary<string, object>? InvoiceSettings { get; init; }

    public List<Contract> Contracts { get; init; } = [];
    public bool ProductChangeAvailable { get; init; }

    public Dictionary<string, object>? DisconnectionNotification { get; init; }

    public bool Editable { get; init; }
}

public record Address
{
    public string Street { get; init; } = default!;
    public string Housenumber { get; init; } = default!;
    public string Postcode { get; init; } = default!;
    public string City { get; init; } = default!;
    public string Country { get; init; } = default!;
}

public record Contract
{
    public string ContractNumber { get; init; } = default!;
    public string Branch { get; init; } = default!;
    public string ScaleType { get; init; } = default!;
    public bool Active { get; init; }
    public DateOnly MoveInDate { get; init; }
    public DateOnly MoveOutDate { get; init; }

    public Consumptions Consumptions { get; init; } = default!;
    public ReadingsHistory ReadingsHistory { get; init; } = default!;
    public EditableReadings EditableReadings { get; init; } = default!;
    public PointOfDelivery PointOfDelivery { get; init; } = default!;

    public string SmartMeterType { get; init; } = default!;
    public string SmartMeterTypeName { get; init; } = default!;
    public string SmartMeterTypeHelp { get; init; } = default!;

    public bool PowerGenerationUnit { get; init; }

    public string Station { get; init; } = default!;
    public string SubStation { get; init; } = default!;

    public GenerationData GenerationData { get; init; } = default!;
    public EnergyCommunityData EnergyCommunityData { get; init; } = default!;
    public Supplier Supplier { get; init; } = default!;

    public string SynthProfile { get; init; } = default!;

    public bool SmartMeterActivationPossible { get; init; }
    public bool LoadProfileActivationPossible { get; init; }
    public bool DailyProfileDispatchActive { get; init; }
    public bool MonthlyProfileDispatchActive { get; init; }
    public bool DailyProfileDispatchInactive { get; init; }
    public bool MonthlyProfileDispatchInactive { get; init; }
    public bool AmisActive { get; init; }
    public bool LoadCurveActive { get; init; }

    public string MonthlyProfileDispatchStatus { get; init; } = default!;
    public string DailyProfileDispatchStatus { get; init; } = default!;

    public bool NonSmart { get; init; }
    public bool AmisMeter { get; init; }
    public bool ProfileActive { get; init; }
    public bool DeviceKeyAvailable { get; init; }
    public bool NewReadingPossible { get; init; }
    public bool OptInPossible { get; init; }
    public bool ReactiveCurrentProfilePresent { get; init; }

    public string DeviceKeyStatus { get; init; } = default!;

    public List<string> AvailableProfileTypes { get; init; } = [];
}

public record Consumptions
{
    public List<ConsumptionValue> Values { get; init; } = [];
    public int TotalConsumption { get; init; }
    public ConsumptionValue LargestConsumption { get; init; } = default!;
}

public record ConsumptionValue
{
    public DateOnly From { get; init; }
    public DateOnly To { get; init; }
    public double Value { get; init; }
    public int NrOfDays { get; init; }
    public double ConsumptionPerDay { get; init; }
}

public record ReadingsHistory
{
    public double CalculatedConsumptionSum { get; init; }
    public double RelevantConsumptionSum { get; init; }
    public string? RelevantConsumptionUnit { get; init; }
    public double MaxConsumptionPerDay { get; init; }

    public Dictionary<string, object>? ReadingsPerMeter { get; init; }
}

public record EditableReadings
{
    public bool NewReadingPossible { get; init; }
}

public record PointOfDelivery
{
    public string MeterPointAdministrationNumber { get; init; } = default!;
    public Meter Meter { get; init; } = default!;

    public List<Profile> Profiles { get; init; } = [];

    public string ActivationStatus { get; init; } = default!;
    public string DailyDispatchStatus { get; init; } = default!;
    public string MonthlyDispatchStatus { get; init; } = default!;

    public DateOnly RetroactiveActivationDate { get; init; }

    public string DeviceKeyStatus { get; init; } = default!;
    public string SnapStatus { get; init; } = default!;

    public Trend MonthlyTrend { get; init; } = default!;
    public Trend YearlyTrend { get; init; } = default!;

    public LastReadings LastReadings { get; init; } = default!;

    public DateOnly MinimumDate { get; init; }
    public DateOnly MaximumDate { get; init; }

    public bool SmartMeterActive { get; init; }
    public bool LoadProfileActive { get; init; }

    public List<string> AvailableProfileTypes { get; init; } = [];

    public DateRange AvailableTimeRange { get; init; } = default!;
}

public record Meter
{
    public string MeterNumber { get; init; } = default!;
}

public record Profile
{
    public DateOnly From { get; init; }
    public DateOnly To { get; init; }

    public string Granularity { get; init; } = default!;
    public string ProfileType { get; init; } = default!;
}

public record Trend
{
    public TrendConsumption ConsumptionOld { get; init; } = default!;
    public TrendConsumption ConsumptionNew { get; init; } = default!;

    public DateTimeRange TimerangeOld { get; init; } = default!;
    public DateTimeRange TimerangeNew { get; init; } = default!;
}

public record TrendConsumption
{
    public double Sum { get; init; }
    public double PerDay { get; init; }
    public int Days { get; init; }
}

public record DateTimeRange
{
    public DateTime From { get; init; }
    public DateTime To { get; init; }
}

public record LastReadings
{
    public List<ReadingValue> Values { get; init; } = [];
    public bool NewReadingPossible { get; init; }
}

public record ReadingValue
{
    public string Meternumber { get; init; } = default!;
    public string Equipmentnumber { get; init; } = default!;
    public string Registernumber { get; init; } = default!;

    public int IntegerPlaces { get; init; }
    public double DecimalPlaces { get; init; }

    public string ReferenceNumber { get; init; } = default!;

    public double CaloricValue { get; init; }
    public double AdditionalValue { get; init; }

    public ReadingResult OldResult { get; init; } = default!;
    public ReadingResultWithTimestamp NewResult { get; init; } = default!;

    public double CalculatedConsumption { get; init; }

    public string UnitForCalculatedConsumption { get; init; } = default!;

    public double RelevantConsumption { get; init; }
}

public record ReadingResult
{
    public int IntegerPlaces { get; init; }
    public double DecimalPlaces { get; init; }
    public bool Plausible { get; init; }
    public double ReadingValue { get; init; }
}

public record ReadingResultWithTimestamp
{
    public DateTime Timestamp { get; init; }
    public int IntegerPlaces { get; init; }
    public double DecimalPlaces { get; init; }
    public bool Plausible { get; init; }
    public double ReadingValue { get; init; }
}

public record DateRange
{
    public DateOnly From { get; init; }
    public DateOnly To { get; init; }
}

public record GenerationData
{
    public bool RecentlyApprovedInFeed { get; init; }
    public bool InFeederInquiryPossible { get; init; }
    public bool SmallInFeederActivationPossible { get; init; }
    public bool SmallInFeederDeactivationPossible { get; init; }
    public bool ShowAnetteLight { get; init; }

    public string TrafficLightColor { get; init; } = default!;
    public string TrafficLightReason { get; init; } = default!;
}

public record EnergyCommunityData
{
    public string Status { get; init; } = default!;

    public List<EnergyCommunityTimeslice> Timeslices { get; init; } = [];

    public bool EnergyCommunityActive { get; init; }
}

public record EnergyCommunityTimeslice
{
    public string EnergyCommunityId { get; init; } = default!;
    public string EnergyCommunityName { get; init; } = default!;

    public DateOnly From { get; init; }
    public DateOnly To { get; init; }

    public string Status { get; init; } = default!;
    public string StatusText { get; init; } = default!;

    public List<Profile> Profiles { get; init; } = [];

    public DateOnly ProfileDataAvailableFrom { get; init; }
    public DateOnly ProfileDataAvailableTo { get; init; }
}

public record Supplier
{
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
}



//         {
//   "contractAccountNumber": "200100024429",
//   "businessPartnerNumber": "1000059501",
//   "description": "Führlinger Martin",
//   "active": true,
//   "branch": "STROM",
//   "address": {
//     "street": "Reitsham",
//     "housenumber": "6",
//     "postcode": "5221",
//     "city": "Lochen am See",
//     "country": "AUSTRIA"
//   },
//   "billedByProvider": false,
//   "bankAccountIn": {},
//   "bankAccountOut": {},
//   "invoiceSettings": {},
//   "contracts": [
//     {
//       "contractNumber": "3000514315",
//       "branch": "STROM",
//       "scaleType": "EEG 7ngem",
//       "active": true,
//       "moveInDate": "2016-02-13",
//       "moveOutDate": "9999-12-31",
//       "consumptions": {
//         "values": [
//           {
//             "from": "2025-04-01",
//             "to": "2026-03-31",
//             "value": 2273,
//             "nrOfDays": 365,
//             "consumptionPerDay": 6.227397260273973
//           },
//           {
//             "from": "2024-09-03",
//             "to": "2025-03-31",
//             "value": 1896,
//             "nrOfDays": 210,
//             "consumptionPerDay": 9.028571428571428
//           },
//           {
//             "from": "2024-04-01",
//             "to": "2024-09-02",
//             "value": 85,
//             "nrOfDays": 155,
//             "consumptionPerDay": 0.5483870967741935
//           },
//           {
//             "from": "2023-04-01",
//             "to": "2024-03-31",
//             "value": 2592,
//             "nrOfDays": 366,
//             "consumptionPerDay": 7.081967213114754
//           },
//           {
//             "from": "2022-04-01",
//             "to": "2023-03-31",
//             "value": 2450,
//             "nrOfDays": 365,
//             "consumptionPerDay": 6.712328767123288
//           },
//           {
//             "from": "2021-04-01",
//             "to": "2022-03-31",
//             "value": 3173,
//             "nrOfDays": 365,
//             "consumptionPerDay": 8.693150684931506
//           },
//           {
//             "from": "2020-04-01",
//             "to": "2021-03-31",
//             "value": 3482,
//             "nrOfDays": 365,
//             "consumptionPerDay": 9.53972602739726
//           }
//         ],
//         "totalConsumption": 15951,
//         "largestConsumption": {
//           "from": "2020-04-01",
//           "to": "2021-03-31",
//           "value": 3482,
//           "nrOfDays": 365,
//           "consumptionPerDay": 9.53972602739726
//         }
//       },
//       "readingsHistory": {
//         "calculatedConsumptionSum": 0,
//         "relevantConsumptionSum": 0,
//         "relevantConsumptionUnit": null,
//         "maxConsumptionPerDay": 0,
//         "readingsPerMeter": {}
//       },
//       "editableReadings": {
//         "newReadingPossible": false
//       },
//       "pointOfDelivery": {
//         "meterPointAdministrationNumber": "AT0030000000000000000000000422410",
//         "meter": {
//           "meterNumber": "3553204"
//         },
//         "profiles": [
//           {
//             "from": "2023-05-07",
//             "to": "2026-05-05",
//             "granularity": "QUARTER_OF_AN_HOUR",
//             "profileType": "ACTIVE_CURRENT"
//           }
//         ],
//         "activationStatus": "SMART_METER_DEACTIVATION_POSSIBLE",
//         "dailyDispatchStatus": "HIDE",
//         "monthlyDispatchStatus": "HIDE",
//         "retroactiveActivationDate": "2026-03-17",
//         "deviceKeyStatus": "ACTIVE",
//         "snapStatus": "ACTIVE",
//         "monthlyTrend": {
//           "consumptionOld": {
//             "sum": 43,
//             "perDay": 1.43333333333333,
//             "days": 30
//           },
//           "consumptionNew": {
//             "sum": 26,
//             "perDay": 0.86666666666667,
//             "days": 30
//           },
//           "timerangeOld": {
//             "from": "2026-03-06T00:00:00",
//             "to": "2026-04-04T23:59:59"
//           },
//           "timerangeNew": {
//             "from": "2026-04-05T00:00:00",
//             "to": "2026-05-05T23:59:59"
//           }
//         },
//         "yearlyTrend": {
//           "consumptionOld": {
//             "sum": 1945.607,
//             "perDay": 5.3304301369863,
//             "days": 365
//           },
//           "consumptionNew": {
//             "sum": 2309.883,
//             "perDay": 6.32844657534247,
//             "days": 365
//           },
//           "timerangeOld": {
//             "from": "2024-04-30T00:00:00",
//             "to": "2025-04-29T23:59:59"
//           },
//           "timerangeNew": {
//             "from": "2025-04-30T00:00:00",
//             "to": "2026-04-30T23:59:59"
//           }
//         },
//         "lastReadings": {
//           "values": [
//             {
//               "meternumber": "3553204",
//               "equipmentnumber": "000000000012634819",
//               "registernumber": "004",
//               "integerPlaces": 6,
//               "decimalPlaces": 3,
//               "referenceNumber": "1.8.1",
//               "caloricValue": 0,
//               "additionalValue": 0,
//               "oldResult": {
//                 "integerPlaces": 0,
//                 "decimalPlaces": 0,
//                 "plausible": true,
//                 "readingValue": 0
//               },
//               "newResult": {
//                 "timestamp": "2026-05-05T00:15:00",
//                 "integerPlaces": 18296,
//                 "decimalPlaces": 0.667,
//                 "plausible": true,
//                 "readingValue": 18296.667
//               },
//               "calculatedConsumption": 0,
//               "unitForCalculatedConsumption": "KWH",
//               "relevantConsumption": 0
//             }
//           ],
//           "newReadingPossible": false
//         },
//         "minimumDate": "2023-05-07",
//         "maximumDate": "2026-05-05",
//         "smartMeterActive": true,
//         "loadProfileActive": false,
//         "availableProfileTypes": [
//           "ACTIVE_CURRENT"
//         ],
//         "availableTimeRange": {
//           "from": "2023-05-07",
//           "to": "2026-05-05"
//         }
//       },
//       "smartMeterType": "ADVANCED_SMART_METER",
//       "smartMeterTypeName": "Intelligentes Messgerät",
//       "smartMeterTypeHelp": "Ihr derzeit installiertes Messgerät unterstützt die Fernauslesung von Messwerten. In der Praxis kann es infolge von Kommunikationsstörungen aber fallweise dazu kommen, dass Zähler keine Werte liefern. Fehlerbehebungen können bis zu 45 Tagen dauern. Im Fall von längerfristigen Kommunikationsstörungen müssen vereinzelt Zähler auf NONSMART (nicht kommunikativer Zähler) gestellt werden!",
//       "powerGenerationUnit": false,
//       "station": "643",
//       "subStation": "14402",
//       "generationData": {
//         "recentlyApprovedInFeed": false,
//         "inFeederInquiryPossible": false,
//         "smallInFeederActivationPossible": false,
//         "smallInFeederDeactivationPossible": true,
//         "showAnetteLight": false,
//         "trafficLightColor": "YELLOW",
//         "trafficLightReason": "NONE"
//       },
//       "energyCommunityData": {
//         "status": "HISTORICAL",
//         "timeslices": [
//           {
//             "energyCommunityId": "AT00300000000RC102797000000972483",
//             "energyCommunityName": "wseg 14403 0524 UW Lengau",
//             "from": "2024-09-03",
//             "to": "2026-05-06",
//             "status": "ACTIVE",
//             "statusText": "Aktiv",
//             "profiles": [
//               {
//                 "from": "2024-09-03",
//                 "to": "2026-05-06",
//                 "granularity": "QUARTER_OF_AN_HOUR",
//                 "profileType": "ENERGY_COMMUNITY_CONSUMPTION_PER_CONTRIBUTION_FACTOR"
//               },
//               {
//                 "from": "2024-09-03",
//                 "to": "2026-05-06",
//                 "granularity": "QUARTER_OF_AN_HOUR",
//                 "profileType": "ENERGY_COMMUNITY_OWN_COVERAGE"
//               }
//             ],
//             "profileDataAvailableFrom": "2024-09-03",
//             "profileDataAvailableTo": "2026-05-06"
//           }
//         ],
//         "energyCommunityActive": true
//       },
//       "supplier": {
//         "id": "AT003003",
//         "name": "Energie AG OÖ - Vertrieb GmbH"
//       },
//       "synthProfile": "Haushalt",
//       "smartMeterActivationPossible": false,
//       "loadProfileActivationPossible": false,
//       "dailyProfileDispatchActive": false,
//       "monthlyProfileDispatchActive": false,
//       "dailyProfileDispatchInactive": false,
//       "monthlyProfileDispatchInactive": false,
//       "amisActive": true,
//       "loadCurveActive": false,
//       "monthlyProfileDispatchStatus": "HIDE",
//       "dailyProfileDispatchStatus": "HIDE",
//       "nonSmart": false,
//       "amisMeter": true,
//       "profileActive": true,
//       "deviceKeyAvailable": true,
//       "newReadingPossible": false,
//       "optInPossible": false,
//       "reactiveCurrentProfilePresent": false,
//       "deviceKeyStatus": "ACTIVE",
//       "availableProfileTypes": [
//         "ACTIVE_CURRENT"
//       ]
//     }
//   ],
//   "productChangeAvailable": false,
//   "disconnectionNotification": {},
//   "editable": true
// }
//