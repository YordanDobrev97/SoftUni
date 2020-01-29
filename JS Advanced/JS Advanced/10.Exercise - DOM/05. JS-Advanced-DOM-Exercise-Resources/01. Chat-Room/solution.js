function solve() {
  const button = document.getElementById("send");
  button.addEventListener("click", () => {
    const message = document.getElementById("chat_input").value;
    const div = document.createElement('div');
    div.setAttribute('class', 'message my-message');
    div.textContent = message;
    document.getElementById('chat_messages').appendChild(div);
    document.getElementById("chat_input").value = '';
  });
}
