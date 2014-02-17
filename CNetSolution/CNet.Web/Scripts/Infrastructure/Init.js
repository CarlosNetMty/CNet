
$(document).ready(function () {
    //Store language when changed
    Defero.Global.LanguageCallbacks.add(function () {
        Collective.Storage.Set("$_Lang", Defero.Global.CurrentLanguage);
    });

    //Load current modules
    $("[data-type='module']").each(function () {
        var control = $(arguments[1]),
            moduleName = control.attr("data-module"),
            namespace = moduleName.split("."),
            resultModule = Defero;

        for (var i = 1; i < namespace.length; i++)
            resultModule = resultModule[namespace[i]];

        var moduleParameters = {};
        if (window.location.search) {
            var searchQuery = window.location.search.replace("?", "");
            searchElements = searchQuery.split("&");

            $.each(searchElements, function () {

                var itemElements = arguments[1].split("=");
                moduleParameters[itemElements[0]] = itemElements[1];
            });
        }
        resultModule.Load(control, moduleParameters);
    });
});