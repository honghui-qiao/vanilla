X = {};
X.Util = {
    getViewportSize: function () {
        var h = window.innerHeight,
            w = window.innerWidth;

        if (typeof w != 'number') {
            if (document.compatMode == 'CSS1Compat') {
                w = document.documentElement.clientWidth;
                h = document.documentElement.clientHeight;
            } else {
                w = document.body.clientWidth;
                h = document.body.clientHeight;
            }
        }

        return { w: w, h: h };
    }
}