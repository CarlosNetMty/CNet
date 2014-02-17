jQuery.namespace("Defero.Global");

// *************** Server ***************
Defero.Global.Get = function (module, data, callback) {

    if (!module.Server) 
        callback();
    else {
        $.ajax({
            url: Defero.Utils.FormatDataURL(module.DataUrl),
            data: data,
            type: "get",
            contentType: "application/json",
            dataType: "json",
            success: function (result) {
                if ($.isFunction(callback))
                    callback(result);
            },
            error: function () {
                Defero.Utils.Notify("Error on Request", "error");
            }
        });
    }
};

Defero.Global.Post = function (url, data, callback) {

    $.ajax({
        type: "POST",
        url: url,
        data: data,
        dataType: "json",
        success: function (response) {
            if ($.isFunction(callback))
                callback(response);
        },
        error: function () {
            Defero.Global.Notify("Error on Request", "error");
        }
    });

}

Defero.Global.Load = function (url, data, viewModel) {

    if ($.isFunction(viewModel))
        Defero.Global.Get(url, data, function (result) {
            return viewModel(result);
        });

    return false;
};

// *************** Navigation ***************

Defero.Global.Navigate = function (relativeUrl) {

    var location = window.location;
    var redirectTo = "{0}//{1}/{2}".format(location.protocol, location.host, relativeUrl);

    window.location = redirectTo;
};

Defero.Global.IsHomePage = function () {

    var pathSections = [];
    var pathData = window.location.pathname.split("/");

    $.each(pathData, function (index, item) { if (item) pathSections.push(item); });

    if (!pathSections.length) return true;
    if (pathSections.length == 1 && pathSections[0] == "Home") return true;
    if (pathSections.length == 2 && pathSections[0] == "Home" && pathSections[1] == "Index") return true;

    return false;
}

// *************** Notification ***************

Defero.Global.Notify = function (contentText, type) {

    if (!Defero.Settings.UseNotifications)
        return;

    var notification = jSuccess;

    if (type && type.indexOf("error") >= 0) notification = jError;
    if (type && type.indexOf("info") >= 0) notification = jNotify;

    notification(contentText, {
        autoHide: true,
        TimeShown: 800,
        HorizontalPosition: "right",
        VerticalPosition: "top"
    });
};

Defero.Global.OnSave = function (redirectUrl) {

    Collective.Global.Notify("Object saved!");

    if (redirectUrl)
        setTimeout(function () {
            Collective.Utils.Navigate(redirectUrl);
        }, 2000);
}

// *************** Storage ***************

Defero.Global.Get = function (key, defaultValue) {

    return $.jStorage.get(key, defaultValue);
}

Defero.Global.Set = function (key, value) {

    return $.jStorage.set(key, value);
}