function register(){
    let id = document.getElementById('register')

    id.addEventListener('click', function(){
        console.log('click event');
    });

    document.getElementById("myBtn").addEventListener("click", function(){
        document.getElementById("demo").innerHTML = "Hello World";
      });
}
register();