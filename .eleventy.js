const fs = require("fs");
module.exports = (function(eleventyConfig) {
    eleventyConfig.addFilter("filesize", function(path) {
        let stat = fs.statSync(path);
        if (stat) {
            return (stat.size / 1024).toFixed(2) + " KB";
        }
        return "";
    });
});

module.exports = function(eleventyConfig) {
    // Filter source file names using a glob
    eleventyConfig.addCollection("tip", function(collectionApi) {
        // Also accepts an array of globs!
        return collectionApi.getFilteredByGlob(["src/tips/*"]); //could be *.md
    });
};