import { useState } from 'react';
import axios from 'axios';
import Payment from './Payment';

const App = () => {
  const [limit, setLimit] = useState(0);
  const [input, setInput] = useState('');
  const [payments, setPayments] = useState([]);

  const onStartClick = () => {
    setPayments(input.split(' '));
  }

  const onResetClick = async () => {
    const { data } = await axios.post('http://localhost:14803/api/card/reset');
    setLimit(data);
    setPayments([]);
    setInput([]);
  }

  return (
    <div className='App'>
      <div className='control'>
        <input value={input} onChange={e => setInput(e.target.value)}/>
        <button onClick={onStartClick}>Start</button>
      </div>
      <div className='control'>
        <span>Limit: {limit}</span>
        <button onClick={onResetClick}>Reset</button>
      </div>
      <table>
        <thead>
          <tr>
            <th>Id</th>
            <th>Amount</th>
            <th>Status</th>
          </tr>
        </thead>
        <tbody>
          {
            payments.map((payment, i) => (
              <Payment 
                id={i + 1}
                amount={payment}
                setLimit={setLimit}
                key={i}
              />
            ))
          }
        </tbody>
      </table>
    </div>
  );
}

export default App;
