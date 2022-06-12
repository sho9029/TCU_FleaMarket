export function getImg() {
    return document.querySelector("#prev-img").src;
}

export function setPrevImg() {
    document.querySelector('#input-img').addEventListener('change', event => {
        const file = event.target.files[0];
        if (!file) {
            return;
        }
        else if (!file.type.match('image/png') && !file.type.match('image/jpeg')) {
            alert('.jpg, .jpegまたは.pngを選択してください。');
            return;
        }

        const reader = new FileReader();
        reader.onload = event => {
            document.querySelector('#prev-img').src = event.target.result;
        }

        reader.readAsDataURL(file);
    });
}
