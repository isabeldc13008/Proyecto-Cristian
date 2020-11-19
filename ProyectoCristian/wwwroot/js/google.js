let btn = document.getElementById("google");

btn.addEventListener('click', () => {
    var provider = new firebase.auth.GoogleAuthProvider();
    firebase.auth().signInWithPopup(provider).then(function (result) {
        localStorage.setItem("usuario", JSON.stringify(result));
        console.log(result);
      
    }).catch(function (error) {
        var errorMessage = error.message;  
    });
});