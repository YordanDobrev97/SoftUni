const routerObject = {
    '/': 'index.html',
    '/styles/site.css': '/styles/site.css',
    '/addCat': 'addCat.html',
    '/images/pawprint.ico': '/images/pawprint.ico',
    '/addBreed': 'addBreed.html',
}

module.exports = (url) => {
    const v = routerObject[url];
    return routerObject[url]
}