"use strict";
var TituloGrid;
(function (TituloGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar este registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Titulo/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    TituloGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(TituloGrid || (TituloGrid = {}));
//# sourceMappingURL=Grid.js.map