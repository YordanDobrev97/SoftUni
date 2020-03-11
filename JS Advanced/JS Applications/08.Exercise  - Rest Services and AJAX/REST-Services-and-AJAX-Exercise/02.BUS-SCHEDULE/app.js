function solve() {
  let currentStop = 'depot';
  let nextStop;

  function depart() {
    let baseUrl = `https://judgetests.firebaseio.com/schedule/${currentStop}.json`;

    fetch(baseUrl)
      .then(request => request.json())
      .then(data => {
        currentStop = data.name;
        nextStop = data.next;

        document.getElementById('depart').disabled = true;
        document.getElementById('arrive').disabled = false;

        document.querySelector('.info').textContent = `Next stop ${currentStop}`;
      });
  }

  function arrive() {
    document.getElementById('depart').disabled = false;
    document.getElementById('arrive').disabled = true;

    document.querySelector('.info').textContent = `Arriving at ${currentStop}`;
    currentStop = nextStop;
  }

  return {
    depart,
    arrive
  };
}

let result = solve();
