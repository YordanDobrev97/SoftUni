function attachEvents() {
  const baseUrl = `https://phonebook-nakov.firebaseio.com/phonebook.json`;

  document.getElementById("btnLoad").addEventListener("click", loadContacts);
  document.getElementById("btnCreate").addEventListener("click", createContact);

  function loadContacts() {
    const ul = document.getElementById("phonebook");

    ul.innerHTML = '';

    fetch(baseUrl)
      .then(request => request.json())
      .then(data => {
        Object.entries(data).forEach(kvp => {
          const id = kvp[0];

          const name = kvp[1].person;
          const phone = kvp[1].phone;

          const li = document.createElement("li");
          li.textContent = `${name}:${phone}`;

          const deleteButton = document.createElement("button");
          deleteButton.textContent = "Delete";
          deleteButton.id = id;

          deleteButton.addEventListener("click", deletePhone);

          li.appendChild(deleteButton);

          ul.appendChild(li);
        });
      });
  }

  function deletePhone() {
    const id = this.getAttribute("id");

    fetch(`https://phonebook-nakov.firebaseio.com/phonebook/${id}.json`, {
      method: "DELETE"
    }).then(() => {
      this.parentNode.remove();
    });
  }

  function createContact() {
    const personName = document.getElementById("person");
    const phone = document.getElementById("phone");

    fetch(baseUrl, {
      method: "POST",
      body: JSON.stringify({
          person: personName.value,
          phone: phone.value
        })
    });

    personName.value = '';
    phone.value = '';
  }
}

attachEvents();