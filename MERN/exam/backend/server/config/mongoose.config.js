const mongoose = require("mongoose");

mongoose.connect("mongodb://localhost/pets_DB", {
    useNewUrlParser: true,
	useUnifiedTopology: true,
})
    .then(() => console.log("Established Connection Successfully!!!"))
    .catch(err => console.log("Connection Failed", err))