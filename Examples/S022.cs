using System;
class ContactNumber {
    string countryCode;
    string areaCode;
    string localNumber;
}
class Name {
    string firstName, lastName;
}
class Person {
    Name english, chinese;
    ContactNumber telNo, faxNo, mobileNo;
}
class Organization {
    string id;
    string englishName;
    string chineseName;
    ContactNumber telephoneNumber, faxNumber;
    Person contactPerson;
    //...
}
