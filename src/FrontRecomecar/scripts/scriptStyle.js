// Visibilidade da senha

function mostrarSenha() {
    var x = document.getElementById("password");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}
function mostrarSenhaConfirmar() {
    var x = document.getElementById("passwordConfirm");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

// mudar página
function paraLogin() {
    window.location.href = "login.html";
}
