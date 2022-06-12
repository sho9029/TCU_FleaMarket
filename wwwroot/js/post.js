export function setPrevImg () {
    document.querySelector('#input-img').addEventListener('change', event => {
        const file = event.target.files[0];
        if (!file) {
            return;
        }
        else if (!file.type.match('image/*')) {
            alert('Please select an image file.');
            return;
        }

        const reader = new FileReader();
        reader.onload = event => {
            document.querySelector('#prev-img').src = event.target.result;
        }

        reader.readAsDataURL(file);
    });
}
