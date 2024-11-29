import xmltodict
import json
import os
import sys

def convert_trx_to_json(trx_path, json_path):
    """
    Convierte un archivo .trx (XML) a .json para ser utilizado en SpecFlow LivingDoc.

    Args:
        trx_path (str): Ruta del archivo .trx de entrada.
        json_path (str): Ruta donde se guardará el archivo .json de salida.
    """
    try:
        # Leer el archivo .trx
        with open(trx_path, 'r', encoding='utf-8') as trx_file:
            trx_content = trx_file.read()

        # Convertir XML a un diccionario
        trx_dict = xmltodict.parse(trx_content)

        # Guardar el diccionario como JSON
        with open(json_path, 'w', encoding='utf-8') as json_file:
            json.dump(trx_dict, json_file, indent=4)

        print(f"Archivo JSON generado correctamente en: {json_path}")

    except Exception as e:
        print(f"Error al convertir el archivo .trx a .json: {e}")

if __name__ == "__main__":
    if len(sys.argv) != 3:
        print("Uso: python trx_to_json.py <ruta_archivo_trx> <ruta_salida_json>")
        sys.exit(1)

    trx_file_path = sys.argv[1]
    json_file_path = sys.argv[2]

    # Verificar que el archivo .trx existe
    if not os.path.exists(trx_file_path):
        print(f"El archivo .trx no existe: {trx_file_path}")
        sys.exit(1)

    # Convertir el archivo .trx a .json
    convert_trx_to_json(trx_file_path, json_file_path)
