"use strict";
exports.__esModule = true;
exports.Account = exports.Customer = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports["default"] = Bank;
var Customer = /** @class */ (function () {
    function Customer(CusId, firstName) {
        this.CusId = CusId;
        this.firstName = firstName;
    }
    return Customer;
}());
exports.Customer = Customer;
var Account = /** @class */ (function () {
    function Account(balance) {
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
