    document.addEventListener('DOMContentLoaded', function () {
            const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]');
            const popoverList = [...popoverTriggerList].map(popoverTriggerEl => new bootstrap.Popover(popoverTriggerEl));
        });




//funcion para generar alertas sobre acciones que realice el usuario
function alertas(tipo, mensaje) {

    switch (tipo) {
        case 1: {
            console.log("si ejecuta alerta")
            Swal.fire({
                icon: "error",
                title: "",
                text: mensaje,
            });

        } break;

        case 2: {
            console.log("si ejecuta alerta")
            Swal.fire({
                icon: "success",
                title: "Dato Guardado Exitosamente",
                text: mensaje,
            });

        } break;

        case 3: {
            console.log("si ejecuta alerta")
            Swal.fire({
                icon: "warning",
                title: "Se elimininará el registro",
                text: mensaje,
            });

        } break;


        case 4: {
            Swal.fire({
                title: "Are you sure?",
                text: "You won't be able to revert this!",
                icon: "warning",
                showCancelButton: true,
                confirmButtonColor: "#3085d6",
                cancelButtonColor: "#d33",
                confirmButtonText: "Yes, delete it!"
            }).then((result) => {
                if (result.isConfirmed) {
                    Swal.fire({
                        title: "Deleted!",
                        text: "Your file has been deleted.",
                        icon: "success"
                    });
                }
            });
        } break;


    }

}


//para convertir la fecha 
function convertirFecha(fechaEnTexto) {
    // Extraer los milisegundos de la cadena
    var milisegundos = parseInt(fechaEnTexto.substring(6, fechaEnTexto.length - 2));

    // Crear un objeto Date con los milisegundos
    var fecha = new Date(milisegundos);

    // Obtener los componentes de la fecha
    var año = fecha.getFullYear();
    var mes = ("0" + (fecha.getMonth() + 1)).slice(-2); // Los meses van de 0 a 11
    var dia = ("0" + fecha.getDate()).slice(-2);


    // Formatear la fecha como desees, por ejemplo: YYYY-MM-DD HH:mm:ss
    var fechaFormateada = dia + "-" + mes + "-" + año;

    return fechaFormateada;
}

//para mostrar en el modal y usando el input date
function convertirFecha2(fechaEnTexto) {
    // Asumiendo que fechaEnTexto tiene el formato adecuado para tu caso
    var milisegundos = Date.parse(fechaEnTexto); // Intentar parsear la fecha directamente

    if (isNaN(milisegundos)) {
        // Si no se puede parsear la fecha, retornar una fecha por defecto o manejar el error
        return '';
    }

    var fecha = new Date(milisegundos);

    var año = fecha.getFullYear();
    var mes = ("0" + (fecha.getMonth() + 1)).slice(-2);
    var dia = ("0" + fecha.getDate()).slice(-2);

    var fechaFormateada = año + "-" + mes + "-" + dia;

    return fechaFormateada;
}




/*function convertirFecha(fechaEnTexto) {
    // Extraer los milisegundos de la cadena
    var milisegundos = parseInt(fechaEnTexto.substring(6, fechaEnTexto.length - 2));

    // Crear un objeto Date con los milisegundos
    var fecha = new Date(milisegundos);

    // Obtener los componentes de la fecha
    var año = fecha.getFullYear();
    var mes = ("0" + (fecha.getMonth() + 1)).slice(-2); // Los meses van de 0 a 11
    var dia = ("0" + fecha.getDate()).slice(-2);
    var horas = ("0" + fecha.getHours()).slice(-2);
    var minutos = ("0" + fecha.getMinutes()).slice(-2);
    var segundos = ("0" + fecha.getSeconds()).slice(-2);

    // Formatear la fecha como desees, por ejemplo: YYYY-MM-DD HH:mm:ss
    var fechaFormateada = año + "-" + mes + "-" + dia + " " + horas + ":" + minutos + ":" + segundos;

    return fechaFormateada;
}*/