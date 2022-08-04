const { readFileSync, promises: fsPromises, existsSync } = require('fs');


// <!-- better regional separator -->
function getTagContents(tag, text) {
    var arr1 = text.split("<!--" + tag + "-->");
    return arr1[arr1.length - 1].split('<!--')[0];
}

function readFile(path) {
    if (existsSync(path) == false)
        return 0;
    return readFileSync(path, 'utf-8');
}
module.exports = {
    layout: "tipLayout.html",
    eleventyComputed: {
        bad_example: data => readFile("src/tips/" + data.page.fileSlug + ".bad_example.cs"),
        good_example: data => readFile("src/tips/" + data.page.fileSlug + ".good_example.cs"),
        instead_of: data => getTagContents("instead-of", readFileSync(data.page.inputPath, 'utf-8')),
        try: data => getTagContents("try", readFileSync(data.page.inputPath, 'utf-8')),
        because: data => getTagContents("because", readFileSync(data.page.inputPath, 'utf-8')),
    }
}