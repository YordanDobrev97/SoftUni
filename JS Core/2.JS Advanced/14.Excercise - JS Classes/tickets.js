
function solve(tickets, sortingCriteria){
    let arrTickets = [];
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    for(let i = 0; i<tickets.length;i++) {
        let element = tickets[i].split('|');
        let destination = element[0];
        let price = Number(element[1]);
        let status = element[2];
        let ticket = new Ticket(destination,price,status);
        arrTickets.push(ticket);
    }
    let sorting = arrTickets.sort((a,b) => {
        if(a[sortingCriteria] < b[sortingCriteria]){
            return -1;
        }
        if(a[sortingCriteria] > b[sortingCriteria]){
            return 1;
        }
        return 0;
    });
    let result = '[';

    for(let i = 0; i<sorting.length;i++) {
        let elements = sorting[i];
        result += `Ticket { destination: ${elements.destination}, price: ${elements.price}, status: ${elements.status} },\n`;
    }
    result += ']';

    return result;
    
}
console.log(solve(['Philadelphia|94.20|available','New York City|95.99|available','New York City|95.99|sold','Boston|126.20|departed'], 'status'));
console.log('\n');
console.log(solve(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
));
