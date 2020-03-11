function getInfo() {
  const stopId = document.getElementById('stopId');
  const baseUrl = `https://judgetests.firebaseio.com/businfo/${stopId.value}.json`;

  fetch(baseUrl)
    .then(request => request.json())
    .then(data => {
      if (!data) {
        throw new Error('Invalid data');
      }

      document.getElementById('buses').innerHTML = '';

      const name = data.name;
      const buses = data.buses;

      document.getElementById('stopName').textContent = name;

      Object.entries(buses).forEach(bus => {
        const busId = bus[0];
        const time = bus[1];

        const li = document.createElement('li');
        li.textContent = `Bus ${busId} arrives in ${time} minutes`;
        document.getElementById('buses').appendChild(li);
      });
    })
    .catch(error => {
        document.getElementById('stopName').textContent = 'Error!';
    });

  stopId.value = '';
}
