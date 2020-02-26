function solve(data) {
    const template = {
        model: '',
        engine: {},
        carriage: {},
        wheels: []
    };

    const engines= [{
           power: 90,
           volume: 1800
        }, {
            power: 120,
            volume: 2400
        }, {
            power: 200,
            volume: 3500
        }
    ];

    const carriage = [
        { type: 'hatchback', color: data.color}, 
        { type: 'coupe', color: data.color}
    ];

    const createdObject = Object.create(template);
    createdObject['model'] = data.model;

    const powerEngine = engines.find(x => data.power <= x.power);
    createdObject['engine'] = {};
    createdObject.engine['power'] = powerEngine['power'];
    createdObject.engine['volume'] = powerEngine['volume'];

    const currentCarriage = carriage.find(x => x.type === data.carriage);

    createdObject['carriage'] = {};
    createdObject.carriage['type'] = currentCarriage['type'];
    createdObject.carriage['color'] = currentCarriage['color'];

    createdObject['wheels']  = data['wheelsize'] % 2 === 0 ? 
                                createdObject['wheels'] = new Array(4).fill(data.wheelsize - 1, 0, 4):
                                createdObject['wheels'] = new Array(4).fill(data.wheelsize, 0, 4);
    return createdObject;
}

console.log(solve({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}));