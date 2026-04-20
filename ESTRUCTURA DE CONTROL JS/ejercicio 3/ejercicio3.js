let user;
let password;

user = prompt("Ingrese su usuario: ");
password = prompt("Ingrese su contraseña: ");

if (user === "admin" && password === "1234") {
    alert("acesso concedido");
}
else {
    alert("acesso Denegado");
}