function validateRequest(obj) {
    let method = obj.method;
    let url = obj.uri;
    let version = obj.version;
    let message = obj.message;

    if(!(method === 'GET' || method === 'POST' || method === 'DELETE'|| method === 'CONNECT')){
        throw new Error('Invalid request header: Invalid Method');
    } 
    if(!(version === 'HTTP/0.9' || version === 'HTTP/1.0' || version === 'HTTP/1.1' || version === 'HTTP/2.0')){
        throw new Error('Invalid request header: Invalid Version');
    }
    let uriRegex = /^[\w.]+$/;
    if(!(uriRegex.test(obj.uri) || obj.uri === '*')){
        throw new Error('Invalid request header: Invalid URI');
    }
    let messageRegex = /^[^<>\\&'"]*$/;
    if(!(messageRegex.test(obj.message))){
        throw new Error('Invalid request header: Invalid Message');
    }

    return obj;
}
validateRequest({
    method: 'POST',
    uri: 'home.bash',
    message: 'rm -rf /*'
  });
  
// validateRequest({
//     method: 'OPTIONS',
//     uri: 'git.master',
//     version: 'HTTP/1.1',
//     message: '-recursive'
// });
  
// console.log(validateRequest({
//     method: 'GET',
//     uri: 'svn.public.catalog',
//     version: 'HTTP/1.1',
//     message: ''}));
