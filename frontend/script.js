getVisitors();
addVisitors();

async function startGreeting() {
    const greetingHeading = document.getElementById("helloHeadingText");
    const myNameHeading = document.getElementById("myNameIsText");

    await delayedWrite(greetingHeading, "Cześć! ... Hello! ... Hola!", 80);
    await delayedWrite(myNameHeading, "I am Cezary ... and this is my cloud resume ", 90);
}

async function delayedWrite(element, text, delay) {
    return new Promise(resolve => {
        let index = 0;
        const intervalId = setInterval(() => {
            const currentChar = text.charAt(index);
            element.textContent += currentChar;
            index++;

            // Check if reached the end of the text
            if (index === text.length) {
                clearInterval(intervalId);
                resolve(); // Stop the interval when all characters are added
            }
        }, delay);
    });
};

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

async function getVisitors() {
    const response = await fetch("https://api.cszacherski.pl/api/visitors", {
        method: "GET", // *GET, POST, PUT, DELETE, etc.
        cache: "no-cache", // *default, no-cache, reload, force-cache, only-if-cached
    });
    const cnt = document.getElementById("visitorsCnt");
    response.text().then(txt => cnt.textContent = txt);
}

async function addVisitors() {
    const response = await fetch("https://api.cszacherski.pl/api/visitors", {
        method: "POST", // *GET, POST, PUT, DELETE, etc.
        mode: "no-cors", // no-cors, *cors, same-origin
        cache: "no-cache", // *default, no-cache, reload, force-cache, only-if-cached
    });
}