function flightInformation(array) {
    let [passenger, town, time, flightNumber, gateNumber] = array;

    console.log(`${passenger}: Destination - ${town}, Flight - ${flightNumber},  Time - ${time}, Gate - ${gateNumber}`);
}

flightInformation(['Departures', 'London', '22:45', 'BR117', '42']);