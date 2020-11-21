console.log("sisi");


let btn = document.getElementById("abrir");
let divItem = document.getElementById("item");
let btnTerminar = document.getElementById("terminar");
let conta = 0;
btn.addEventListener('click', () => {
    conta++;
    let idproducto = document.getElementById("idproducto").value;
    let nombrep = document.getElementById("nombrep").value;
    let precio = document.getElementById("preciop").value;
    let imagen = document.getElementById("imgp").value;


    let articulos = JSON.parse(localStorage.getItem("productos"));
    if (articulos == null) {
        divItem.innerHTML += `
             <input type="hidden" name="productosc[${conta}].id_productos" value="${idproducto}"/>
                <img src="../../imagenes/${imagen}" style="width:130px; heigth:100px; margin-top:10px;" />
                <div class="textos" style="margin-top:-55px;">
                    <p class="nombre-item" id="nombre">Articulo: ${nombrep}</p>
                    <p id="precio">Precio:${precio}</p>
                    <p id="eliminar" onclick="eliminar(${idproducto})" class="btn btn-danger mt-3 eliminar">X</p>
                </div>
           
            <div>
                <label class="titulocantidad" style="margin-top:10px;">Cantidad</label>
                <input id="cantidad" type="number" class="form-control cantidad" onchange="totalC(${precio})" value="1" />
                <input type="hidden" name="productosc[${conta}].cantidad" value="${cantidad}">
            </div>
            
     `;
        totalC(precio);
    } else {

        articulos.forEach((r) => {
            divItem.innerHTML += `
            <form id="fproducto">
             <input type="hidden" name="productosc[${conta}].id_productos" value="${idproducto}"/>
             <input type="hidden" value="${r.idproducto}"/>
                <img src="../../imagenes/${r.imagen}" style="width:130px; heigth:100px; margin-top:10px;" />
                <div class="textos" style="margin-top:-55px;">
                    <p class="nombre-item" id="nombre">Articulo: ${r.nombrep}</p>
                    <p id="precio">Precio:${r.precio}</p>
                    <p id="eliminar" onclick="eliminar(${r.idproducto})" class="btn btn-danger mt-3 eliminar">X</p>
                </div>
           
            <div>
                <label class="titulocantidad" style="margin-top:10px;">Cantidad</label>
                <input id="cantidad" type="number" class="form-control cantidad" onchange="totalC(${r.precio})" value="1" />
               <input type="hidden" name="productosc[${conta}].cantidad" value="${cantidad}">
  
            </div>
            </form>
             `;
            totalC(r.precio);

        })
    }


    let cantidad = document.getElementById("cantidad").value;
    const articulo = {
        idproducto,
        nombrep,
        precio,
        cantidad,
        imagen

    };

    let arreglo = JSON.parse(localStorage.getItem("productos"));
    if (arreglo == null) {
        let productos = [];
        productos.push(articulo);
        localStorage.setItem("productos", JSON.stringify(productos));
    } else {
        arreglo.push(articulo);
        localStorage.setItem("productos", JSON.stringify(arreglo));
    }
});



let totalC = (e) => {
    let productos = JSON.parse(localStorage.getItem("productos"));
    let totalA = 0;
    if (productos != null) {
        let precios = productos.map(i => i.precio);
        totalA = precios.reduce((e, b) => Number(e) + Number(b));

    }
    let cantidad = document.getElementById("cantidad").value;
    let total = document.getElementById("total");
    let totalC = (cantidad * e) + Number(totalA);

    if (!total.empty) {

        total.innerHTML = `
           <p class="precio-total" id="tTotal">Total: ${totalC}</p> `;
    }
}

let eliminar = (k) => {

    let productos = JSON.parse(localStorage.getItem("productos"));
    for (let i = 0; i < productos.length; i++) {
        if (productos[i].idproducto == k) {
            console.log("entre");
            console.log("indice" + i);
            productos.splice(i, 1);

        }
    }


}


let llenarProductos = (e) => {
    let productos = [];
    productos.push(e);
}

