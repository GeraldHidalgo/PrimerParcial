"use strict";
var DepartamentoGrid;
(function (DepartamentoGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar este registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Departamento/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    DepartamentoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(DepartamentoGrid || (DepartamentoGrid = {}));
//# sourceMappingURL=Grid.js.map