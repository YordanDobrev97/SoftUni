import { postData, load } from './fetch.js';

function attachEvents() {

   document.querySelector('.load').addEventListener('click', loadData);
   document.querySelector('.add').addEventListener('click', addData);

   function loadData() {
        load();
   }
   
   function addData() {
       const angler = document.querySelector('#addForm .angler');
       const weight = document.querySelector('#addForm .weight');
       const species = document.querySelector('#addForm .species');
       const location = document.querySelector('#addForm .location');
       const bait = document.querySelector('#addForm .bait');
       const captureTime = document.querySelector('#addForm .captureTime');

       postData(angler, weight, species, location, bait, captureTime);
   }
}

attachEvents();