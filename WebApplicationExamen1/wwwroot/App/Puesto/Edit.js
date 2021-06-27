"use strict";
var PuestoEdit;
(function (PuestoEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(PuestoEdit || (PuestoEdit = {}));
//# sourceMappingURL=Edit.js.map