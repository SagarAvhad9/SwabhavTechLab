PrinDetails([{ firstName: 'Sagar', id: 101, lastName: 'Avhad' },
    { firstName: 'Kunal', id: 201, lastName: 'Sarode', Location: 'Mumbai' }]);
function PrinDetails(customers) {
    for (var _i = 0, customers_1 = customers; _i < customers_1.length; _i++) {
        var c = customers_1[_i];
        console.log(c);
    }
}
