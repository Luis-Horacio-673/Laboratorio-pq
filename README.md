# Display para UFS-200

Se comienza a indicar los pasos realizados en el software, indicando los pasos que se van siguiendo.

- Desde aqúi se ve que es necesario el armado de la variable sMillosnew que se va a necesitar para definir el momento de inicio del seguimiento.
- Se verifica el caso de (nbyte == 0) Si llega un 0x05 (ENQ) se trasnmite un ACK. Si llega un 0x02 (STX) se escribe STX en el textBox correspondiente.
- Se verifica el caso de (nbyte == 1) El primer byte de Trial se escribe en el textBox TRIAL. Borrando lo anterior
- Se verifica el caso de (nbyte == 2). Se agrega el segundo byte de Trial al texBox TRIAL
- Se verifica el caso de (nbyte == 3) El primer byte de Status se escribe en el textBox STATUS. Borrando lo anterior
- Se verifica el caso de (nbyte == 4). Se agrega el segundo byte de Status al texBox STATUS
- Se verifica el caso de (nbyte == 5). Se agrega el tercer byte de Status al texBox STATUS
- Se verifica el caso de (nbyte == 6). Se agrega el cuarto byte de Status al texBox STATUS