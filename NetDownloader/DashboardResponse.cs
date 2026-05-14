namespace NetDownloader;

public record DashboardResponse
{
    // {
    public IList<BusinessPartner> BusinessPartners { get; init; } = [];

    public IList<ContractAccount> ContractAccounts { get; init; } = [];
    //     
    //   ],
    //   "contractAccounts": [
    //     {
    //       "contractAccountNumber": "200100024429",
    //       "businessPartnerNumber": "1000059501",
    //       "active": true,
    //       "description": "Führlinger Martin",
    //       "address": "5221 Lochen am See, Reitsham 6",
    //       "contracts": [
    //         {
    //           "contractNumber": "3000514315",
    //           "meterPointAdministrationNumber": "AT0030000000000000000000000422410",
    //           "branch": "STROM",
    //           "active": true,
    //           "scaleType": "EEG 7ngem",
    //           "powerGenerationUnit": false,
    //           "moveInDate": "2019-03-05",
    //           "moveOutDate": "9999-12-31"
    //         }
    //       ],
    //       "numberOfContracts": 1,
    //       "branch": "STROM"
    //     }
    //   ],
    //   "totalNumberOfContractAccounts": 2,
    //   "totalNumberOfStromPods": 2,
    //   "displaySearch": false
    // }
}

public record ContractAccount
{
    public string ContractAccountNumber { get; init; }
    public string BusinessPartnerNumber { get; init; }
    public List<Contract> Contracts { get; init; } = [];
    public int NumberOfContracts  { get; init; }
    public string Branch  { get; init; }
        //       "contractAccountNumber": "200196086681",
        //       "businessPartnerNumber": "1000059501",
        //       "active": true,
        //       "description": "Martin Führlinger",
        //       "address": "5221 Lochen am See, Reitsham 6",
        //       "contracts": [
        
        //       ],
        //       "numberOfContracts": 1,
        //       "branch": "STROM"
        //     },
}

public record Contract
{
    public string contractNumber { get; init; }
    public string MeterPointAdministrationNumber { get; init; }
    public string Branch { get; init; }
    public bool Active { get; init; }
    public string ScaleType { get; init; }
    public bool PowerGenerationUnit { get; init; }
    public DateOnly MoveInDate  { get; init; }
    public DateOnly MoveOutDate { get; init; }
    //           "contractNumber": "3003813717",
    //           "meterPointAdministrationNumber": "AT0030000000000000000000030087756",
    //           "branch": "STROM",
    //           "active": true,
    //           "scaleType": "Gem.Erz. / Erzeugung",
    //           "powerGenerationUnit": true,
    //           "moveInDate": "2023-08-18",
    //           "moveOutDate": "9999-12-31"
    //         }
}

public record BusinessPartner
{
    public string Type { get; init;  }
    public string BusinessPartnerNumber { get; init; }
    //       "type": "PERSON",
    //       "businessPartnerNumber": "1000059501",
    //       "entity": {
    //         "type": "person",
    //         "address": {
    //           "street": "Reitsham",
    //           "housenumber": "6",
    //           "postcode": "5221",
    //           "city": "Lochen am See",
    //           "country": "AUSTRIA"
    //         },
    //         "landline": {},
    //         "mobile": {
    //           "number": "68120922593",
    //           "country": "AUSTRIA"
    //         },
    //         "firstname": "Martin",
    //         "lastname": "Führlinger",
    //         "dateOfBirth": "1984-05-07",
    //         "salutation": "MR",
    //         "fullname": "Martin Führlinger"
    //       },
    //       "mobileMissing": false,
    //       "mobileVerified": true,
    //       "ecommunicationActive": true,
    //       "ecommunicationInactive": false,
    //       "ecommunicationStatus": "ACTIVE",
    //       "email": "mfuehrlinger@gmx.at"
    //     }
}



// {
        //   "businessPartners": [
        //     {
        //       "type": "PERSON",
        //       "businessPartnerNumber": "1000059501",
        //       "entity": {
        //         "type": "person",
        //         "address": {
        //           "street": "Reitsham",
        //           "housenumber": "6",
        //           "postcode": "5221",
        //           "city": "Lochen am See",
        //           "country": "AUSTRIA"
        //         },
        //         "landline": {},
        //         "mobile": {
        //           "number": "68120922593",
        //           "country": "AUSTRIA"
        //         },
        //         "firstname": "Martin",
        //         "lastname": "Führlinger",
        //         "dateOfBirth": "1984-05-07",
        //         "salutation": "MR",
        //         "fullname": "Martin Führlinger"
        //       },
        //       "mobileMissing": false,
        //       "mobileVerified": true,
        //       "ecommunicationActive": true,
        //       "ecommunicationInactive": false,
        //       "ecommunicationStatus": "ACTIVE",
        //       "email": "mfuehrlinger@gmx.at"
        //     }
        //   ],
        //   "contractAccounts": [
        //     {
        //       "contractAccountNumber": "200196086681",
        //       "businessPartnerNumber": "1000059501",
        //       "active": true,
        //       "description": "Martin Führlinger",
        //       "address": "5221 Lochen am See, Reitsham 6",
        //       "contracts": [
        //         {
        //           "contractNumber": "3003813717",
        //           "meterPointAdministrationNumber": "AT0030000000000000000000030087756",
        //           "branch": "STROM",
        //           "active": true,
        //           "scaleType": "Gem.Erz. / Erzeugung",
        //           "powerGenerationUnit": true,
        //           "moveInDate": "2023-08-18",
        //           "moveOutDate": "9999-12-31"
        //         }
        //       ],
        //       "numberOfContracts": 1,
        //       "branch": "STROM"
        //     },
        //     {
        //       "contractAccountNumber": "200100024429",
        //       "businessPartnerNumber": "1000059501",
        //       "active": true,
        //       "description": "Führlinger Martin",
        //       "address": "5221 Lochen am See, Reitsham 6",
        //       "contracts": [
        //         {
        //           "contractNumber": "3000514315",
        //           "meterPointAdministrationNumber": "AT0030000000000000000000000422410",
        //           "branch": "STROM",
        //           "active": true,
        //           "scaleType": "EEG 7ngem",
        //           "powerGenerationUnit": false,
        //           "moveInDate": "2019-03-05",
        //           "moveOutDate": "9999-12-31"
        //         }
        //       ],
        //       "numberOfContracts": 1,
        //       "branch": "STROM"
        //     }
        //   ],
        //   "totalNumberOfContractAccounts": 2,
        //   "totalNumberOfStromPods": 2,
        //   "displaySearch": false
        // }