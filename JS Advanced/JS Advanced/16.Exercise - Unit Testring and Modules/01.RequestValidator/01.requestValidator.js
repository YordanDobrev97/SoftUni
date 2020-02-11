function validRequest(request) {
    validRequest(request);
    return request;

    function validRequest(request) {
        validMethod(request);
        validUri(request);
        validVersion(request);
        validMessage(request);    
    }
    function validMethod(request) {
        const validMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
        if (!request.hasOwnProperty('method') || !validMethods.includes(request.method)) {
           throw new Error('Invalid request header: Invalid Method');  
        }
    }

    function validUri(request) {
        const uriPattern = /^(\*|[a-zA-Z\d\.]+)$/gim;

        if (!request.hasOwnProperty('uri') || !uriPattern.test(request.uri)) {
            throw new Error('Invalid request header: Invalid URI');
        }
    }

    function validVersion(request) {
        const validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1',  'HTTP/2.0'];
        
        if (!request.hasOwnProperty('version') || !validVersions.includes(request.version)) {
            throw new Error('Invalid request header: Invalid Version');
        }
    }

    function validMessage(request) {
        const messagePattern = /^[^<>\\&'"]*$/gim;

        if (!request.hasOwnProperty('message') || !messagePattern.test(request.message)) {
            throw new Error('Invalid request header: Invalid Message');
        }
    }
}

console.log(validRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
}));