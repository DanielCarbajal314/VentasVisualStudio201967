const toasty = new Toasty({
    classname: "toast",
    transition: "fade",
    insertBefore: true,
    duration: 4000,
    enableSounds: true,
    autoClose: true,
    progressBar: true,
    sounds: {
        info: "/Content/sounds/info/1.mp3",
        success: "/Content/sounds/success/1.mp3",
        warning: "/Content/sounds/warning/1.mp3",
        error: "/Content/sounds/error/1.mp3",
    }
});

const ServicioDeNotificaciones = {
    NotificarError: (mensaje) => {
        toasty.error(mensaje);
    },
    NotificarExito: (mensaje) => {
        toasty.success(mensaje);
    },
    NotificarInformacion: (mensaje) => {
        toasty.info(mensaje);
    }
}

axios.interceptors.response.use(
    response => response,
    error => {
        if (error.response.data.MensajesDeError) {
            error.response.data.MensajesDeError.forEach(x => {
                ServicioDeNotificaciones.NotificarError(x)
            });
        }      
        return Promise.reject(error);
    }
);