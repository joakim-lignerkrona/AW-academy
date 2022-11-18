// get the parameter name from the URL
let name = document.location.search.substring(1);
name = name.substring(name.indexOf("name=") + 5, name.indexOf("&"));

console.log(`Hello ${name.length > 1 ? name : "world"}!`);
