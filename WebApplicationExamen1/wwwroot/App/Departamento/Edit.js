"use strict";
var DepartamentoEdit;
(function (DepartamentoEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(DepartamentoEdit || (DepartamentoEdit = {}));
//# sourceMappingURL=Edit.js.map