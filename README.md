# Display Chile para UFS-200

## Temas para el soft

- El primer caso de perdida de millones es cuando pasa de 99.999.999 a 100.0xx.xxx. En este caso los digitos enviados por la UFS se ponen en cero para los millones
- El segundo caso es que dada la situacion anterior ahora se debe incrementar los millones cuando pase desde 999.999 a 1.0xx.xxx
- ahora agrego para que la maquina responda con NACK cada 3 paquetes de datos completos.
- Elimino la etiqueta Rx,  el TextBox RX y el Button de Borrado.
- agrego etiquetas y textBox par mostrar lo que se se recibe para el display y el codigo para que se mueste la recepción tal cual llega.


Se comienza a indicar los pasos realizados en el software, indicando los pasos que se van siguiendo.

- Desde aqúi se ve que es necesario el armado de la variable sMillosnew que se va a necesitar para definir el momento de inicio del seguimiento.
- Se verifica el caso de (nbyte == 0) Si llega un 0x05 (ENQ) se trasnmite un ACK. Si llega un 0x02 (STX) se escribe STX en el textBox correspondiente.
- Se verifica el caso de (nbyte == 1) El primer byte de Trial se escribe en el textBox TRIAL. Borrando lo anterior
- Se verifica el caso de (nbyte == 2). Se agrega el segundo byte de Trial al texBox TRIAL
- Se verifica el caso de (nbyte == 3) El primer byte de Status se escribe en el textBox STATUS. Borrando lo anterior
- Se verifica el caso de (nbyte == 4). Se agrega el segundo byte de Status al texBox STATUS
- Se verifica el caso de (nbyte == 5). Se agrega el tercer byte de Status al texBox STATUS
- Se verifica el caso de (nbyte == 6). Se agrega el cuarto byte de Status al texBox STATUS
- Se verifica el caso de (nbyte == 7). Se agrega el primer byte de Amount al texBox DB  (decena de billones)
- Se verifica el caso de (nbyte == 8). Se agrega el segundo byte de Amount al texBox UB  (unidad de billones)
- Se verifica el caso de (nbyte == 9). Se agrega el Tercer byte de Amount al texBox CMM  (centena de miles de millones)
- Se verifica el caso de (nbyte == 10). Se agrega el cuarto byte de Amount al texBox DMM  (Decena de miles de millones)
- Se verifica el caso de (nbyte == 11). Se agrega el quinto byte de Amount al texBox UMM  (Unidad de miles de millones)
- Se verifica el caso de (nbyte == 12). Se agrega el sexto byte de Amount al texBox CM  (Centena de millones)
- Se verifica el caso de (nbyte == 13). Se agrega el septimo byte de Amount al texBox DM  (Decena de millones)
- Se verifica el caso de (nbyte == 14). Se agrega el octavo byte de Amount al texBox UM  (Unidad de millones)
- Se verifica el caso de (nbyte == 15). Se agrega el noveno byte de Amount al texBox CMIL  (Centena de miles)
- Se verifica el caso de (nbyte == 16). Se agrega el décimo byte de Amount al texBox DMIL  (Decena de miles)
- Se verifica el caso de (nbyte == 17). Se agrega el 11 avo byte de Amount al texBox UMIL  (Unidades de miles)
- Se verifica el caso de (nbyte == 18). Se agrega el 12 avo byte de Amount al texBox CEN  (Centena)
- Se verifica el caso de (nbyte == 19). Se agrega el 13 avo byte de Amount al texBox DEC  (Decena)
- Se verifica el caso de (nbyte == 20). Se agrega el 14 avo byte de Amount al texBox UNI  (Unidad)