const axios = require('axios');

let makeRequest = async (id) => {
    const amount = Math.ceil(Math.random() * 5000);
    const result = await axios.post(
        `http://localhost:14803/api/card/amount?amount=${amount}`
    );
    console.log(`${id} - сума: $${amount} - ${result.data}`);
};

calculateTime = async (threads) => {
    const start = Date.now();

    await Promise.all(
        [...Array(threads).keys()].map(makeRequest)
    );

    const end = Date.now() - start;
    console.log(`Elapsed time: ${end / 1000} seconds`);
}

calculateTime(20);
