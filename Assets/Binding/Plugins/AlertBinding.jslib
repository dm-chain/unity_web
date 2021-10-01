mergeInto(LibraryManager.library, {
    Alert: function(message) {
        alert(Pointer_stringify(message));
    }
})