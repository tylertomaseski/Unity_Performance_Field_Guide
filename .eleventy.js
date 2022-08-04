module.exports = function(eleventyConfig) {
    // Filter source file names using a glob
    eleventyConfig.addCollection("tip", function(collectionApi) {

        //could be *.md
        return collectionApi.getFilteredByGlob(["src/tips/*"]).sort(function(a, b) {
            var val = a.data.difficulty - b.data.difficulty;
            if (val == 0)
                a.data.title.localeCompare(b.data.title);
            return val;
        });
    });
}