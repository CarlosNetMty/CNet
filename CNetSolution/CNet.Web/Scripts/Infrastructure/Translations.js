jQuery.namespace("Defero.Translations");

Defero.Translations = {
    SPA: {
        Galleries: "Explorar",
        About: "Acerca",
        Contact: "Contacto",
        Language: "Lenguaje",
        Welcome: "Bienvenido",
        SecurePayment: "Pago Seguro",
        OrderHistory: "Hisorial de Pagos",
        TermsOfService: "Terminos de Servicio",
        AllRightsReserved: "Todos los derechos reservados",
        Login: "Login",
        Register: "Registrar",
        FilterBy: "Filtar Por",
        ExcludingPrice: "(excluyendo impuestos y envio)",
        AddToCart: "Agregar a carrito de compra",
        Related: "Relacionados",
        Username: "Nombre de Usuario",
        Password: "Contraseña",
        Email: "Email",
        ConfirmPassword: "Confirmar contraseña",
        HeaderLogin: "LogIn y compra en linea",
        HeaderRegister: "No tienes una cuenta? Registrate!",
        LoginAndRegister: "Login & Registro",
        AdminAccess: "Acceso a administración",
        Name: "Nombre",
        Phone: "Telefono",
        Message: "Mensaje",
        Send: "Enviar",
        ViewLargerMap: "Ver en Grande",
        Presenting: "Presentando",
        StartingAt: "A partir de",
        OrderNow: "Ordena en linea"
    },
    ENG: {
        Galleries: "Browse",
        About: "About",
        Contact: "Contact",
        Language: "Language",
        Welcome: "Welcome back",
        SecurePayment: "Secure Payment",
        OrderHistory: "Order History",
        TermsOfService: "Terms of Service",
        AllRightsReserved: "All rights reserved",
        Login: "Login",
        Register: "Register",
        FilterBy: "Filter By",
        ExcludingPrice: "(excluding TAX & Shipping)",
        AddToCart: "Add to Shopping Cart",
        Related: "Related",
        Username: "Username",
        Password: "Password",
        Email: "Email",
        ConfirmPassword: "Confirm password",
        HeaderLogin: "Login & Shop Online",
        HeaderRegister: "Don´t have an Account? Register!",
        LoginAndRegister: "Login & Register",
        AdminAccess: "Admininistration Access",
        Name: "Name",
        Phone: "Phone",
        Message: "Message",
        Send: "Send",
        ViewLargerMap: "View Larger Map",
        Presenting: "Presenting",
        StartingAt: "Starting at",
        OrderNow: "Order now online"
    },
    Get: function (key) {
        return this[Defero.Global.CurrentLanguage][key];
    },
    Set: function (view) {
        var lang = Defero.Global.CurrentLanguage;
        var translations = Defero.Translations[lang];

        function getTransformedTranslation(control, key)
        {
            var text = translations[control.data("key")];

            var hasTransform = control.is("[data-transform]");
            if (hasTransform) {
                switch (control.data("transform")) {
                    case "AllCaps":
                        text = text.toUpperCase();
                        break;
                }
            }

            return text;
        }
        
        $.each(view.find("[data-key]"), function () {

            var control = $(this);
            var text = getTransformedTranslation(control, control.data("key")); 
            
            control.text(text);
        });

        $.each(view.find("[data-holder]"), function () {

            var control = $(this);
            var text = getTransformedTranslation(control, control.data("holder")); 
                        
            control.attr("placeholder", text);
        });
    }
};