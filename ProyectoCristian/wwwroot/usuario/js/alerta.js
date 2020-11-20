let carrito= () => {
    let carrito = document.getElementById("carrito");
    let articulos = localStorage.getItem("staplesbmincart");
    let n_articulos = articulos.length;
    if (n_articulos != 0) {
        console.log(n_articulos);
    }
    console.log("el que no funciono eres tu");
};
carrito();
    
