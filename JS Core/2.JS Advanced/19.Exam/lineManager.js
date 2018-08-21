class LineManager {
    constructor(stops){
        this.stopArr = [];
        this.setStops = stops;
        this.totalMinutes = 0;
    }
    get atDepot(){ 
        if(this.stopArr.length > 1){
            return false;
        }
        return true;
    }
    get nextStopName(){
    }
    get currentDelay(){
    }
    set setStops(stop){
        for(let item of stop)
        {
            let name = item.name;
            let timeToNext = item.timeToNext;
            if(name !== '' || timeToNext > 0 || Number(timeToNext)){
                this.stopArr.push(item);
            }else{
                throw new Error('Error');
            }
        }
    }
    arriveAtStop(minutes){


        this.totalMinutes +=minutes;
    }
    toString(){
        let result = '';
        for(let i = 1; i<this.stopArr.length;i++) {
            result += 'Line summary\n';
            result += `- Next stop: ${this.stopArr[i].name}\n`;
            result += `- Stops covered: ${i - 1}\n`;
            result += `- Time on course: ${this.totalMinutes} minutes`;
        }

        return result;
    } 
}
let man = new LineManager([
    {name: 'Depot', timeToNext: 4},
    {name: 'Romanian Embassy', timeToNext: 2},
    {name: 'TV Tower', timeToNext: 3},
    {name: 'Interpred', timeToNext: 4},
    {name: 'Dianabad', timeToNext: 2},
    {name: 'Depot', timeToNext: 0},
]);
// Travel through all the stops until the bus is at depot
while(man.atDepot === false) {
    console.log(man.toString());
    man.arriveAtStop(4);
}

console.log(man.toString());

// Should throw an Error (minutes cannot be negative)
man.arriveAtStop(-4);
// Should throw an Error (last stop reached)
man.arriveAtStop(4);

// Should throw an Error at initialization
const wrong = new LineManager([
    { name: 'Stop', timeToNext: { wrong: 'Should be a number'} }
]);

