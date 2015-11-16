/// <reference path="../scripts/typings/knockout/knockout.d.ts" />
/// <reference path="../scripts/typings/knockout.validation/knockout.validation.d.ts" />
var ksj;
(function (ksj) {
    var validation;
    (function (validation) {
        var IndexViewModel = (function () {
            function IndexViewModel() {
                this.NoValidation = ko.observable("");
                this.CustomerNameValidation = ko.observable("");
                this.ContactNameValidation = ko.observable("");
                this.AddressValidation = ko.observable("");
                this.CityValidation = ko.observable("");
                this.CountryValidation = ko.observable("");
                this.PostalCodeValidation = ko.observable("");
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
            return IndexViewModel;
        })();
        validation.IndexViewModel = IndexViewModel;
    })(validation = ksj.validation || (ksj.validation = {}));
})(ksj || (ksj = {}));
//# sourceMappingURL=IndexViewModel.js.map