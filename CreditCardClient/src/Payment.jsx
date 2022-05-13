import { useCallback, useEffect, useState } from 'react';
import axios from 'axios';

const STATUS_COLOR = {
  pending: 'yellow',
  successful: 'green',
  failed: 'red',
}

const Payment = ({ id, amount, setLimit }) => {
  const [status, setStatus] = useState('pending');

  const makePayment = useCallback(async () => {
    const { data: { status, limit } } = await axios.post(
      'http://localhost:14803/api/card/payment', 
      { amount }
    );
    setStatus(status);
    setLimit(limit);
  }, [setLimit, setStatus, amount]);

  useEffect(() => {
    makePayment();
  }, [makePayment]);

  return <tr>
    <td>{id}</td>
    <td>{amount}</td>
    <td style={{ backgroundColor: STATUS_COLOR[status] }}>{status}</td>
  </tr>
}

export default Payment;