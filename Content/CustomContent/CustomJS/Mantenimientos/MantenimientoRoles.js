var dataTable; // Variable global para DataTables

const estatus = "a";

$(document).ready(function () {
    ListarRoles(); // Llama a la función para listar los roles al cargar la página
    ListaRoles(); // Llama a la función para llenar el dropdown de roles
});

function ListarRoles() {
    fetch('/Mantenimientos/MantenimientoRoles/ListaRoles?estatus=' + estatus)
        .then(function (res) {
            if (res.ok) {
                return res.json();
            }
        })
        .then(function (data) {
            let tbody = document.querySelector("#myTable tbody");
            tbody.innerHTML = '';
            data.forEach(function (datosP) {
                let fila = document.createElement("tr");
                fila.innerHTML = `
                    <td>${datosP.codigoRol}</td>
                    <td>${datosP.nombreRol}</td>
                    <td>${datosP.descripcionRol}</td>
                    <td>${convertirFecha(datosP.fechaCrea)}</td>
                    <td>${validarEstado(datosP.estatus)}</td>
                    <td>
                        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#ejemploModalActualizar" onclick="Empleado_Seleccionado(this)">Editar</button>
                        <button type="button" class="btn btn-danger btnEliminar" onclick="EliminarRol(${datosP.codigoRol},'${datosP.nombreRol}');">Eliminar</button>
                    </td>
                `;
                tbody.appendChild(fila);
            });

            //// Destruye DataTables si ya está inicializado
            
            //InicializarDataTable();
            //// Inicializa DataTables con los nuevos datos
            
        })
        .catch(function (error) {
            console.error('Error:', error);
        });
    
}


function validarEstado(estatus) {
    if (estatus == "a") {
        return "Activo";
    }
}

//function DestruirDataTable() {
//    if (dataTable) {
//        dataTable.destroy();
//    }
//}

//function InicializarDataTable() {
//    var table = $('#myTable1').DataTable({
//        "paging": true, // Habilitar paginación
//        "lengthMenu": [5, 10, 20], // Opciones de cantidad de registros por página
//        "columnDefs": [
//            { "orderable": false, "targets": -1 } // Deshabilitar ordenamiento en la última columna (acciones)
//        ],
//        "language": {

//            "lengthMenu": "Mostrar _MENU_ registros por página",
//            "zeroRecords": "No se encontraron registros",
//            "info": "Mostrando página _PAGE_ de _PAGES_",
//            "infoEmpty": "No hay registros disponibles",
//            "infoFiltered": "(filtrado de _MAX_ registros totales)",
//            "search": "Buscar:",
//            "paginate": {
//                "first": "Primero",
//                "last": "Último",
//                "next": "Siguiente",
//                "previous": "Anterior"
//            }
//        }
//    });

//    dataTable = table;
//}

// Función para actualizar un rol
function ActualizarRol() {
    let codigoRol = document.getElementById('codigoRolActualizar').value;
    let nombreRol = document.getElementById('Nombre_actualizar').value;
    let descripcionRol = document.getElementById('DescripcionActualizar').value;
    let fechaCrea = document.getElementById('fechaCreaActualizar').value;

    if (codigoRol == "" || nombreRol == "" || descripcionRol == "" || fechaCrea == "") {
        alertas(3,"Debe llenar los campos!!!")
        return;
    }

    fetch('/Mantenimientos/MantenimientoRoles/editarRol', {
        method: 'POST',
        body: JSON.stringify({
            codigoRol: codigoRol,
            nombreRol: nombreRol,
            descripcionRol: descripcionRol,
            fechaCrea: fechaCrea
        }),
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(function (res) {
            if (res.ok) {
                return res.json();
            }
        })
        .then(function (data) {
            console.log(data);
            if (data === true) {
               // DestruirDataTable();
                ListarRoles();
                alertas(2, "Rol actualizado correctamente!!!")


                // Cierra el modal de edición
                $('#ejemploModalActualizar').modal('hide');

                // Actualiza la tabla después de la edición
                
            } else {
                console.log("Error al editar rol");
                alertas(1, "Error al editar el rol!!!")

            }
        })
        .catch(function (error) {
            console.error("Error:", error);
        });
}
function Empleado_Seleccionado(boton) {
    var fila = boton.closest('tr');
    var codigoRol = fila.cells[0].innerText;
    var nombreRol = fila.cells[1].innerText;
    var descripcionRol = fila.cells[2].innerText;
    var fechaCrea = fila.cells[3].innerText;

    document.getElementById('codigoRolActualizar').value = codigoRol;
    document.getElementById('Nombre_actualizar').value = nombreRol;
    document.getElementById('DescripcionActualizar').value = descripcionRol;
    var fechaFormateada = convertirFecha2(fechaCrea);
    document.getElementById('fechaCreaActualizar').value = fechaFormateada;
}



function ListaRoles() {
    fetch('/Mantenimientos/MantenimientoRoles/ListaRoles?estatus=' + estatus) //peticion de los datos
        .then(function (res) {
            if (res.ok) {
                return res.json();
            }
        })
        .then(function (data) { //data trae todos los datos que necesito
            let dropdownRoles = document.getElementById("listroles");
            let selectedValue = dropdownRoles.value; //inicializa en 0 el valor
            dropdownRoles.innerHTML = ""; //texto en blanco
            let defaultOption = document.createElement("option"); //creamos la opcion
            defaultOption.text = "Selecciona un Rol"; //texto inicial
            defaultOption.value = ""; //valor inicial
            dropdownRoles.appendChild(defaultOption); //agregamos la opcion al dropdown
            data.forEach(function (datosP) {
                let opcionDropdown = document.createElement("option"); //creo la opcion nueva
                opcionDropdown.appendChild(document.createTextNode(datosP.nombreRol)); //creo un nodo con el nombre
                opcionDropdown.value = datosP.codigoRol //asigno el valor para esa opcion creada
                dropdownRoles.appendChild(opcionDropdown);//agrego la opcion al componente
                if (opcionDropdown.value === selectedValue) { //valido que al seleccionar alguna ocpion sea true o mejor dicho se coloque 
                    opcionDropdown.selected = true;
                }
            });
        })
        .catch(function (error) {
            console.error('Error:', error);
        });
}

function InsertarRol() {
 
    let nombreRol = document.getElementById('Nombre').value
    let descripcionRol = document.getElementById('Descripcion').value
    let fechaCrea = document.getElementById('fechaCrea').value

    if (nombreRol == "" || descripcionRol == "" || fechaCrea == "") {
        alertas(3, "Debe llenar los campos!!!")
        return;
    }
    fetch('/Mantenimientos/MantenimientoRoles/guardarRol', {
        method: 'POST',
        body: JSON.stringify({
            nombreRol: nombreRol,
            descripcionRol: descripcionRol,
            fechaCrea: fechaCrea
        }),
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(function (res) {
            return res.json();
        })
        .then(function (data) {
            if (data === true) {
                console.log("Insert realizado");
                /*DestruirDataTable();*/
                ListarRoles();
                alertas(2, "Rol creado correctamente!!!")
                document.getElementById("formulario").reset();
                ListarRol();
            } else {
                console.log("Insert fallido");
                alertas(1, "Error al editar el rol!!!")
            }
        })
        .catch(function (error) {
            console.error("Error:", error);
        });
}



function EliminarRol(codigo, nombreRol) {

    Swal.fire({
        title: "Esta seguro?",
        text: `Eliminar rol ${nombreRol}`,
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Si, eliminar",
        cancelButtonText: "No, volver"
    }).then((result) => {

        if (result.isConfirmed) {

            fetch('/Mantenimientos/MantenimientoRoles/eliminarRol?codigo=' + codigo)
                .then(function (res) {
                    if (res.ok) {
                        return res.json();
                    }
                })
                .then(function (data) {
                    console.log(typeof (data), data)
                    if (data === true) {
                        swal.fire({
                            icon: "success",
                            text: "Eliminado Correctamente"
                        });
                        ListarRoles();
                    } else {

                        console.log("Insert fallido");
                        Swal.fire({
                            icon: "error",
                            title: "Oops...",
                            text: "No se pudo eliminar el registro"
                        });
                    }
                })
                .catch(function (error) {
                    console.error("Error:", error);
                });
        }
    });

}



