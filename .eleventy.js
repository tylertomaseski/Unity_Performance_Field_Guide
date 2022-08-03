module.exports = function(eleventyConfig) {
    // Filter source file names using a glob
    eleventyConfig.addCollection("tip", function(collectionApi) {
        // Also accepts an array of globs!
        return collectionApi.getFilteredByGlob(["src/tips/*"]); //could be *.md
    });
}