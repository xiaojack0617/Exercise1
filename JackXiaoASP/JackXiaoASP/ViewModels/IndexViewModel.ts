/// <reference path="../scripts/typings/knockout/knockout.d.ts" />
/// <reference path="../scripts/typings/knockout.validation/knockout.validation.d.ts" />
 
module ksj.validation {

  

    export class IndexViewModel {
        public NoValidation: KnockoutObservable<string> = ko.observable("");
        public CustomerNameValidation: KnockoutObservable<string> = ko.observable("");
        public ContactNameValidation: KnockoutObservable<string> = ko.observable("");
        public AddressValidation: KnockoutObservable<string> = ko.observable("");
        public CityValidation: KnockoutObservable<string> = ko.observable("");
        public CountryValidation: KnockoutObservable<string> = ko.observable("");
        public PostalCodeValidation: KnockoutObservable<string> = ko.observable("");
       

        constructor() {
            this.CustomerNameValidation.extend({
                required: true,
                minLength: 2,
                maxLength: 30,

            });

            this.ContactNameValidation.extend({
                required: true,
                minLength: 2,
                maxLength: 30,
            });

            this.AddressValidation.extend({
                required: true,
               
            });

            this.CityValidation.extend({
                required: true,
                minLength: 2,
                maxLength: 20,
            });

            this.CountryValidation.extend({
                required: true,
                minLength: 2,
                maxLength: 30,
            });


            this.PostalCodeValidation.extend({
                required: true,
                minLength: 4,
                maxLength: 10,
            });

       

            
           


        }



    }


} 