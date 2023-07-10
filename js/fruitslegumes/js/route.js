const route = (event) => {
    event = event || window.event;
    event.preventDefault();
    console.log(window.history);
    window.history.pushState({}, "", event.target.href);
    handleLocation();

};




const routes = {
    "/": "./pages/legumes.html",
    "/vegetables": "./pages/vegetables.html",
    "/sells": "./pages/sales.html",
    "/newSells": "./pages/newSells.html",
    "/newVegetables": "./pages/newVegetables.html",
};




const handleLocation = async () => {
    const path = window.location.pathname;
    console.log(path);
    const route = routes[path];
    const html = await fetch(route).then((data) => data.text());
    document.getElementById("sectionToLoad").innerHTML = html;
};




window.onpopstate += handleLocation;
window.route = route;
handleLocation();