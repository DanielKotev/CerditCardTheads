const axios = require('axios');

let makeRequest = async (id) => {
    const amount = Math.ceil(Math.random() * 5000);
    const result = await axios.post(
        `http://localhost:14803/api/card/amount?amount=${amount}`
    );
    console.log(`${id} - сума: $${amount} - ${result.data}`);
};

for (let i = 1; i <= 5; i++) makeRequest(i);
