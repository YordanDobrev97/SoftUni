function encodeAndDecodeMessages() {
    const buttons = document.getElementsByTagName('button');
    
    const encodeButton = buttons[0];
    const decodeButton = buttons[1];
    const textarea = document.getElementsByTagName('textarea');

    encodeButton.addEventListener('click', () => {
        const textareaValue = textarea[0].value;
        let encodeValue = encodeMessage(textareaValue);
        textarea[1].value = encodeValue; 
        textarea[0].value = '';
        function encodeMessage(textareaValue) {
            let result = '';
    
            for(let item of textareaValue) {
                let numValue = item.charCodeAt(0) + 1;
                let newValue = String.fromCharCode(numValue);
                result += newValue;
            }
            return result;
        }
    });

    decodeButton.addEventListener('click', () => {
        const value = textarea[1].value;
        
        const decodeValue = decodeMessage(value);
        console.log(decodeValue);
        textarea[1].value = decodeValue;
        textarea[0].value = '';
        function decodeMessage(textareaValue) {
            let result = '';
            for(let item of textareaValue) {
                let numValue = item.charCodeAt(0) - 1;
                let newValue = String.fromCharCode(numValue);
                result += newValue;
            }
            return result;
        }
    });
}