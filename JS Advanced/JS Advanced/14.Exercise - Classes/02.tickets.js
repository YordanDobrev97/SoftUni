function solve(array, sortingCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    const destinations = [];
    for(let item of array) {
        const parts = item.split('|');
        const currentDestination = parts[0];
        const price = Number(parts[1]);
        const status = parts[2];

        const currentTicket = new Ticket(currentDestination, price, status);
        destinations.push(currentTicket);
    }

     if (sortingCriteria === 'destination') {
         return destinations.sort((a,b) => {
             return a.destination.localeCompare(b.destination);
         })
     } else if (sortingCriteria === 'status'){
         return destinations.sort((a,b) => {
             return a.status.localeCompare(b.status);
         })
     }

     return destinations.sort((a,b) => {
        return a.price - b.price;
    })
}

console.log(solve(['Philadelphia|94.20|available', 'New York City|95.99|available', 'New York City|95.99|sold','Boston|126.20|departed'],
'destination'
));