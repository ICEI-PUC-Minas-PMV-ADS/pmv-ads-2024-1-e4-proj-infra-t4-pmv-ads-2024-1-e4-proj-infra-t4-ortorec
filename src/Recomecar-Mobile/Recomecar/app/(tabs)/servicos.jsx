import { View, Text, SafeAreaView, Image, ScrollView } from 'react-native'
import { Link, router } from "expo-router";
import React from 'react'

import { images } from "../../constants"
import CustomButton from '@/components/CustomButton'

const Servicos = () => {
  return (
    <SafeAreaView className='h-full '>

      <ScrollView>

        <View className='mt-20 mb-10 px-8 space-y-6'>
          <View className="justify-between items-center flex-row mb-6">

            <View>
              <Text className="text-2xl font-psemibold">
                Serviços
              </Text>
            </View>

            <View className="mt-1.5">
              <Image
                source={images.recomecarLogoPequeno}
                className="w-20 h-20"
                resizeMode="contain"
                
              />
            </View>

          </View>

          <Text className="text-lg">
          Para garantir eficiência operacional e prolongar a vida útil de seus aparelhos ortopédicos, oferecemos <Text className='text-secondary'>serviço de manutenção</Text> por uma equipe altamente qualificada e comprometida.
          </Text>

          <Text className="text-lg font-psemibold">
            <Text className='text-secondary'>Agende um pedido de manutenção</Text> no número: (31) 9 9999-9999
          </Text>

          <Text className="text-2xl font-psemibold">
            Manutenção Preventiva
          </Text>

          <Text className="text-lg">
          Realizamos inspeções, substituição de peças e ajustes necessários para <Text className='text-secondary'>garantir o desempenho ideal</Text> do seu equipamento. 
          </Text>

          <Text className="text-2xl font-psemibold">
            Manutenção Corretiva
          </Text>

          <Text className="text-lg">
          Em caso de falhas ou avarias, nossa equipe de técnicos está pronta para intervir realizando diagnóstico, reparos e substituição de componentes defeituosos. Entre em contato conosco e <Text className='text-secondary'>agende um horário!</Text> Atendemos a domicilio (RMBH) ou você pode trazer seu equipamento. 
          </Text>

        </View>

      </ScrollView>

    </SafeAreaView>
  )
}

export default Servicos