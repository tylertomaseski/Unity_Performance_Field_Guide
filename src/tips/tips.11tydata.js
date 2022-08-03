const { readFileSync, promises: fsPromises } = require('fs');


// <!-- better regional separator -->
function getTagContents(index, text) {
    return text.split(/<!--section-->/)[index + 1];
}

module.exports = {
    layout: "tipLayout.html",
    eleventyComputed: {
        bad_example: data => readFileSync("src/tips/" + data.page.fileSlug + ".bad_example.cs", 'utf-8'),
        good_example: data => readFileSync("src/tips/" + data.page.fileSlug + ".good_example.cs", 'utf-8'),
        instead_of: data => getTagContents(0, readFileSync(data.page.inputPath, 'utf-8')),
        try: data => getTagContents(1, readFileSync(data.page.inputPath, 'utf-8')),
        because: data => getTagContents(2, readFileSync(data.page.inputPath, 'utf-8')),
    }
}