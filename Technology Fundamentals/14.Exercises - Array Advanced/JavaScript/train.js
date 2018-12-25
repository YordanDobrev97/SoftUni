function solve(input){
    let  train = input.shift();
    train =  train.split(' ');
    train =  train.map(el => Number(el));

    let maxCapacity = Number(input.shift());
    
    for (let index = 0; index < input.length; index++) {
        let command = input[index].split(' ')[0];
        let passengers = undefined;
        if(command == 'Add'){
            passengers = Number(input[index].split(' ')[1]);
            train.push(passengers);
        }else{
            passengers = Number(input[index].split(' ')[0]);
            for (let index = 0; index < train.length; index++) {
                const element = train[index];
                let countPassengers = element + passengers;
                
                if (countPassengers <= maxCapacity){
                    train[index] = countPassengers;
                    break;
                }
            }
        }
    }
    console.log(train.join(' '));
}
solve(['32 54 21 12 4 0 23', '75', 
'Add 10', 'Add 0', '30', '10', '75']);
